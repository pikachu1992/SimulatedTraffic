using Newtonsoft.Json;
using SimLib;
using System;
using System.Threading.Tasks;
using WebSocketSharp;

namespace SimulatedTraffic
{
    public partial class Form1 : SimConnectForm
    {
        private WebSocket webSocket;

        private string OAuthToken
        { get; set; }

        // Response number 
        int response = 1;

        // Output text 
        string output = "";

        public Form1()
        {
            InitializeComponent();

            FSX.Player.Callsign = "TSZ213";
        }

        private void displayText(string s)
        {
            // remove first string from output 
            output = output.Substring(output.IndexOf("\n") + 1);

            // add the new string 
            output += "\n" + response++ + ": " + s;

            // display it 
            txtLog.Text = output;
        }

        private async Task Send()
        {
            while (webSocket.IsAlive)
            {
                FSX.Aircraft player = await FSX.Player.Get();

                string data = JsonConvert.SerializeObject(player);

                webSocket.Send(data);

                int millisecondDelay = 1500;
                await Task.Delay(millisecondDelay);
            }
        }

        private void Receive(object sender, MessageEventArgs e)
        {
            FSX.Aircraft traffic = JsonConvert.DeserializeObject<FSX.Aircraft>(
                e.Data);

            traffic.ModelName = "C172";

            FSX.Traffic.Set(traffic);
        }

        private async void btnGeXpndrAsync_Click(object sender, EventArgs e)
        {
            Radios r = await SimObjectType<Radios>.RequestDataOnSimObjectType();
            displayText(r.Transponder.ToString("X3"));
        }

        private async void btnCreateAITraffic_Click(object sender, EventArgs e)
        {           

            FSX.Sim.OnRecvAssignedObjectId += Sim_OnRecvAssignedObjectId;

            await SimObjectType<AircraftsTelemetry>.AICreateParkedATCAircraft("C172", "TSZ101");         
            
        }

        uint objID;

        private void Sim_OnRecvAssignedObjectId(Microsoft.FlightSimulator.SimConnect.SimConnect sender, Microsoft.FlightSimulator.SimConnect.SIMCONNECT_RECV_ASSIGNED_OBJECT_ID data)
        {
            displayText(data.dwObjectID.ToString());

            objID = data.dwObjectID;
        }

        private async void btnSetAiFlightPlan_Click(object sender, EventArgs e)
        {
            await SimObjectType<AircraftsTelemetry>.AISetAircraftFlightPlan(objID);
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            webSocket = new WebSocket(@"wss://fa-live.herokuapp.com/chat");

            webSocket.OnMessage += Receive;

            webSocket.Connect();

            await Send();
        }

        private async void btnSendAITrafficInstruction_Click(object sender, EventArgs e)
        {
            AircraftsTelemetry t = new AircraftsTelemetry();

            await SimObjectType<AircraftsTelemetry>.SetDataOnSimObjectAITraffic(objID, t);
        }

        private async void btnRequestAIState_Click(object sender, EventArgs e)
        {
            AircraftsTelemetry t = await SimObjectType<AircraftsTelemetry>.RequestDataOnSimObjectAITraffic(Convert.ToUInt32(objID));
            displayText(JsonConvert.SerializeObject(t.title));
        }
    }
}

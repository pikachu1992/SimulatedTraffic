using SimLib;
using System;

namespace SimulatedTraffic
{
    public partial class Form1 : SimConnectForm
    {
        // Response number 
        int response = 1;

        // Output text 
        string output = "";

        public Form1()
        {
            InitializeComponent();
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

        private async void btnGeXpndrAsync_Click(object sender, EventArgs e)
        {
            Radios r = await SimObjectType<Radios>.RequestDataOnSimObjectType();
            displayText(r.Transponder.ToString("X3"));
        }

        private async void btnCreateAITraffic_Click(object sender, EventArgs e)
        {
            FSX.Aircraft a = new FSX.Aircraft();

            AircraftsTelemetry t = new AircraftsTelemetry();

            t.latitude = 38.767214;
            t.longitude = -9.143428;
            t.altitude = 380;
            t.pitch = 0;
            t.bank = 0;
            t.magHeading = 030;
            t.onGround = 1;
            t.airspeed = 0;

            await SimObjectType<AircraftsTelemetry>.AICreateNonATCAircraft("C172", "TSZ101", t);

            displayText(a.ObjectId.ToString());
        }
    }
}

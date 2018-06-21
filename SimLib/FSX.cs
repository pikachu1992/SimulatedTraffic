using Microsoft.FlightSimulator.SimConnect;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimLib
{
    public static class FSX
    {
        public static SimConnect Sim;

        internal static Dictionary<int, Type> idMap = new Dictionary<int, Type>();

        internal static Dictionary<Type, int> typeMap = new Dictionary<Type, int>();

        public class Aircraft
        {
            public string Callsign
            { get; set; }

            public string ModelName
            { get; set; }

            public int ObjectId
            { get; internal set; }

            public AircraftsTelemetry State
            { get; set; }

            public async void Create()
            {
                ObjectId = await SimObjectType<AircraftsTelemetry>.
                    AICreateNonATCAircraft(ModelName, Callsign, State);
            }

            internal async Task<AircraftsTelemetry> Read()
            {
                State = await SimObjectType<AircraftsTelemetry>
                    .RequestDataOnSimObjectType();

                return State;
            }

            public async void Update(Aircraft newTraffic)
            {
                State = newTraffic.State;

                await SimObjectType<AircraftsTelemetry>.
                    SetDataOnSimObject((uint)ObjectId, State);
            }
        }
    }
}

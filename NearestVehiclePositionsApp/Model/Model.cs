using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestVehiclePositions.Model
{
    public record VehiclesPosition(
        int PositionId, 
        string VehicleRegistration,
        LocationPosition Position, ulong RecordedTimeUTC);
    public record LocationPosition(double Latitude, double Longitude);  
}

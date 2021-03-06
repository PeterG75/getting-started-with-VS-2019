using VisualStudioUnitTesting;
// <copyright file="ContainerShipFactory.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace VisualStudioUnitTesting
{
    /// <summary>A factory for VisualStudioUnitTesting.ContainerShip instances</summary>
    public static partial class ContainerShipFactory
    {
        /// <summary>A factory for VisualStudioUnitTesting.ContainerShip instances</summary>
        [PexFactoryMethod(typeof(ContainerShip))]
        public static ContainerShip Create(double maxWeight_d, string value_s)
        {
            ContainerShip containerShip = new ContainerShip(maxWeight_d);
            containerShip.ShipNumber = value_s;
            return containerShip;

            // TODO: Edit factory method of ContainerShip
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}

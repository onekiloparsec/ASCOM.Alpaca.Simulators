//DO NOT EDIT, AUTO-GENORATED
using ASCOM.Common.Alpaca;
using ASCOM.Simulators;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace ASCOM.Alpaca.Simulators
{
    /// <summary>
    /// Autogenerated DO NOT EDIT
    /// OmniSim only, not part of Alpaca
    /// </summary>
    [ServiceFilter(typeof(AuthorizationFilter))]
    [ApiController]
    [Route("simulator/v1/")]
public class RotatorSettingsController : ProcessBaseController
{
        /// <summary>
        /// OmniSim Only - The ASCOM Interface Version, allowed values are 1-4
        /// </summary>
        /// <remarks>
        /// <para>The ASCOM Interface Version, allowed values are 1-4</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/interfaceversion")]
        public ActionResult<ASCOM.Common.Alpaca.IntResponse> InterfaceVersion(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.InterfaceVersionSetting.Value, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID);
        }
        /// <summary>
        /// OmniSim Only - The ASCOM Interface Version, allowed values are 1-4
        /// </summary>
        /// <remarks>
        /// <para>The ASCOM Interface Version, allowed values are 1-4</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="InterfaceVersion">The ASCOM Interface Version, allowed values are 1-4</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/interfaceversion")]
        public ActionResult<Response> InterfaceVersion(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [Required][FromForm][SwaggerSchema("The ASCOM Interface Version, allowed values are 1-4")] System.Int16 InterfaceVersion,
            [FromForm][SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [FromForm][SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => { ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.InterfaceVersionSetting.Value = InterfaceVersion; }, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID, $"InterfaceVersion={InterfaceVersion}");
        }
        /// <summary>
        /// OmniSim Only - The starting position 0 to 359.999
        /// </summary>
        /// <remarks>
        /// <para>The starting position 0 to 359.999</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/position")]
        public ActionResult<ASCOM.Common.Alpaca.DoubleResponse> Position(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.Position.Value, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID);
        }
        /// <summary>
        /// OmniSim Only - The starting position 0 to 359.999
        /// </summary>
        /// <remarks>
        /// <para>The starting position 0 to 359.999</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="Position">The starting position 0 to 359.999</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/position")]
        public ActionResult<Response> Position(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [Required][FromForm][SwaggerSchema("The starting position 0 to 359.999")] System.Single Position,
            [FromForm][SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [FromForm][SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => { ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.Position.Value = Position; }, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID, $"Position={Position}");
        }
        /// <summary>
        /// OmniSim Only - The rotation rate in degrees per second
        /// </summary>
        /// <remarks>
        /// <para>The rotation rate in degrees per second</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/rotationrate")]
        public ActionResult<ASCOM.Common.Alpaca.DoubleResponse> RotationRate(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.RotationRate.Value, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID);
        }
        /// <summary>
        /// OmniSim Only - The rotation rate in degrees per second
        /// </summary>
        /// <remarks>
        /// <para>The rotation rate in degrees per second</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="RotationRate">The rotation rate in degrees per second</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/rotationrate")]
        public ActionResult<Response> RotationRate(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [Required][FromForm][SwaggerSchema("The rotation rate in degrees per second")] System.Double RotationRate,
            [FromForm][SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [FromForm][SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => { ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.RotationRate.Value = RotationRate; }, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID, $"RotationRate={RotationRate}");
        }
        /// <summary>
        /// OmniSim Only - True if the rotator can reverse
        /// </summary>
        /// <remarks>
        /// <para>True if the rotator can reverse</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/canreverse")]
        public ActionResult<ASCOM.Common.Alpaca.BoolResponse> CanReverse(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.CanReverse.Value, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID);
        }
        /// <summary>
        /// OmniSim Only - True if the rotator can reverse
        /// </summary>
        /// <remarks>
        /// <para>True if the rotator can reverse</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="CanReverse">True if the rotator can reverse</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/canreverse")]
        public ActionResult<Response> CanReverse(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [Required][FromForm][SwaggerSchema("True if the rotator can reverse")] System.Boolean CanReverse,
            [FromForm][SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [FromForm][SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => { ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.CanReverse.Value = CanReverse; }, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID, $"CanReverse={CanReverse}");
        }
        /// <summary>
        /// OmniSim Only - True if the rotator is reversed
        /// </summary>
        /// <remarks>
        /// <para>True if the rotator is reversed</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/reverse")]
        public ActionResult<ASCOM.Common.Alpaca.BoolResponse> Reverse(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.Reverse.Value, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID);
        }
        /// <summary>
        /// OmniSim Only - True if the rotator is reversed
        /// </summary>
        /// <remarks>
        /// <para>True if the rotator is reversed</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="Reverse">True if the rotator is reversed</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/reverse")]
        public ActionResult<Response> Reverse(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [Required][FromForm][SwaggerSchema("True if the rotator is reversed")] System.Boolean Reverse,
            [FromForm][SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [FromForm][SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => { ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.Reverse.Value = Reverse; }, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID, $"Reverse={Reverse}");
        }
        /// <summary>
        /// OmniSim Only - The current Sync Offset, 0 to 359.999
        /// </summary>
        /// <remarks>
        /// <para>The current Sync Offset, 0 to 359.999</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/syncoffset")]
        public ActionResult<ASCOM.Common.Alpaca.DoubleResponse> SyncOffset(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.SyncOffset.Value, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID);
        }
        /// <summary>
        /// OmniSim Only - The current Sync Offset, 0 to 359.999
        /// </summary>
        /// <remarks>
        /// <para>The current Sync Offset, 0 to 359.999</para>
        /// </remarks>
        /// <param name="DeviceNumber">Zero based device number as set on the server (A uint32 with a range of 0 to 4294967295)</param>
        /// <param name="SyncOffset">The current Sync Offset, 0 to 359.999</param>
        /// <param name="ClientID">Client's unique ID.</param>
        /// <param name="ClientTransactionID">Client's transaction ID.</param>
        /// <response code="200">Transaction complete or exception</response>
        /// <response code="400" examples="Error message describing why the command cannot be processed">Method or parameter value error, check error message</response>
        /// <response code="500" examples="Error message describing why the command cannot be processed">Server internal error, check error message</response>
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ApiExplorerSettings(GroupName = "OmniSim")]        [Route("rotator/{DeviceNumber}/syncoffset")]
        public ActionResult<Response> SyncOffset(
            [Required][DefaultValue(0)][SwaggerSchema(Strings.DeviceIDDescription, Format = "uint32")][Range(0, 4294967295)] uint DeviceNumber,
            [Required][FromForm][SwaggerSchema("The current Sync Offset, 0 to 359.999")] System.Single SyncOffset,
            [FromForm][SwaggerSchema(Strings.ClientIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientID = 0,
            [FromForm][SwaggerSchema(Strings.ClientTransactionIDDescription, Format = "uint32")][Range(0, 4294967295)] uint ClientTransactionID = 0)
        {
            return ProcessRequest(() => { ((DeviceManager.GetRotator(DeviceNumber) as ASCOM.Simulators.Rotator)).RotatorHardware.SyncOffset.Value = SyncOffset; }, DeviceManager.ServerTransactionID, ClientID, ClientTransactionID, $"SyncOffset={SyncOffset}");
        }
}
}

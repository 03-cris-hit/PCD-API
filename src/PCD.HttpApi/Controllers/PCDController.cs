using PCD.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PCD.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PCDController : AbpControllerBase
{
    protected PCDController()
    {
        LocalizationResource = typeof(PCDResource);
    }
}

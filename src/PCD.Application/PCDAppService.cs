using System;
using System.Collections.Generic;
using System.Text;
using PCD.Localization;
using Volo.Abp.Application.Services;

namespace PCD;

/* Inherit your application services from this class.
 */
public abstract class PCDAppService : ApplicationService
{
    protected PCDAppService()
    {
        LocalizationResource = typeof(PCDResource);
    }
}

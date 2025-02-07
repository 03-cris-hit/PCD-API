using Microsoft.Extensions.Localization;
using PCD.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PCD;

[Dependency(ReplaceServices = true)]
public class PCDBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<PCDResource> _localizer;

    public PCDBrandingProvider(IStringLocalizer<PCDResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}

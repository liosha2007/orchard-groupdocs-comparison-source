using EmbedComparison.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace EmbedComparison.Drivers
{
    public class MapDriver : ContentPartDriver<EmbedComparisonPart>
    {
        protected override DriverResult Display(EmbedComparisonPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_EmbedComparison",
                () => shapeHelper.Parts_EmbedComparison(EmbedKey: part.EmbedKey, Guid: part.Guid, FrameWidth: part.FrameWidth, FrameHeight: part.FrameHeight));
        }

        //GET
        protected override DriverResult Editor(EmbedComparisonPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_EmbedComparison_Edit",
                                () => shapeHelper.EditorTemplate(TemplateName: "Parts/EmbedComparison", Model: part, Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(EmbedComparisonPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}

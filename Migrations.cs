using System.Data;
using EmbedComparison.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace EmbedComparison
{
    public class Migrations : DataMigrationImpl
    {

        public int Create()
        {
            // Creating table EmbedComparisonRecord
            SchemaBuilder.CreateTable("EmbedComparisonRecord", table => table
                .ContentPartRecord()
                .Column("EmbedKey", DbType.String)
                .Column("Guid", DbType.String)
                .Column("FrameWidth", DbType.Int32)
                .Column("FrameHeight", DbType.Int32)
            );

            ContentDefinitionManager.AlterPartDefinition(
                typeof(EmbedComparisonPart).Name, cfg => cfg.Attachable());

            return 1;
        }

        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterTypeDefinition("EmbedComparisonWidget", cfg => cfg
                .WithPart("EmbedComparisonPart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            ContentDefinitionManager.AlterPartDefinition(
                typeof(EmbedComparisonPart).Name, cfg => cfg.Attachable());

            return 2;
        }
    }
}
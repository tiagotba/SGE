namespace SGEDAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class terceiraCarga18092018 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OCO_OCORRENCIA", "FL_STATUS_OCORRENCIA", c => c.Boolean(nullable: false));
            AddColumn("dbo.VEIC_VEICULO", "Id_Cliente", c => c.Int(nullable: false));
            AddColumn("dbo.DES_DESOCUPACAO", "Id_Setor", c => c.Int(nullable: false));
            CreateIndex("dbo.VEIC_VEICULO", "Id_Cliente");
            CreateIndex("dbo.DES_DESOCUPACAO", "Id_Setor");
            AddForeignKey("dbo.VEIC_VEICULO", "Id_Cliente", "dbo.CLI_CLIENTE", "Id_Cliente");
            AddForeignKey("dbo.DES_DESOCUPACAO", "Id_Setor", "dbo.SET_SETOR", "Id_Setor");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DES_DESOCUPACAO", "Id_Setor", "dbo.SET_SETOR");
            DropForeignKey("dbo.VEIC_VEICULO", "Id_Cliente", "dbo.CLI_CLIENTE");
            DropIndex("dbo.DES_DESOCUPACAO", new[] { "Id_Setor" });
            DropIndex("dbo.VEIC_VEICULO", new[] { "Id_Cliente" });
            DropColumn("dbo.DES_DESOCUPACAO", "Id_Setor");
            DropColumn("dbo.VEIC_VEICULO", "Id_Cliente");
            DropColumn("dbo.OCO_OCORRENCIA", "FL_STATUS_OCORRENCIA");
        }
    }
}

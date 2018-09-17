namespace SGEDAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeiraCarga : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "bd_sge_sql.CLI_CLIENTE",
                c => new
                    {
                        Id_Cliente = c.Int(nullable: false),
                        Nome_Cliente = c.String(maxLength: 500),
                        Rg_Cliente = c.String(maxLength: 13),
                        Cpf_Cliente = c.String(maxLength: 18),
                        E_Func_Cliente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Cliente)
                .ForeignKey("bd_sge_sql.USU_USUARIO", t => t.Id_Cliente)
                .Index(t => t.Id_Cliente);
            
            CreateTable(
                "bd_sge_sql.OCO_OCORRENCIA",
                c => new
                    {
                        Id_Ocorrencia = c.Int(nullable: false, identity: true),
                        DATA_OCORRENCIA = c.DateTime(nullable: false),
                        TITULO_OCORRENCIA = c.String(maxLength: 500),
                        DESC_OCORRENCIA = c.String(),
                        Id_Cliente = c.Int(nullable: false),
                        Id_Tipo_Ocorrencia = c.Int(nullable: false),
                        Id_Veiculo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Ocorrencia)
                .ForeignKey("bd_sge_sql.CLI_CLIENTE", t => t.Id_Cliente)
                .ForeignKey("bd_sge_sql.TIPO_OCORRENCIA", t => t.Id_Tipo_Ocorrencia)
                .ForeignKey("bd_sge_sql.VEIC_VEICULO", t => t.Id_Veiculo)
                .Index(t => t.Id_Cliente)
                .Index(t => t.Id_Tipo_Ocorrencia)
                .Index(t => t.Id_Veiculo);
            
            CreateTable(
                "bd_sge_sql.TIPO_OCORRENCIA",
                c => new
                    {
                        Id_Tipo_Ocorrencia = c.Int(nullable: false, identity: true),
                        DSC_TIPO_OCORRENCIA = c.String(nullable: false),
                        FL_STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Tipo_Ocorrencia);
            
            CreateTable(
                "bd_sge_sql.VEIC_VEICULO",
                c => new
                    {
                        Id_Veiculo = c.Int(nullable: false, identity: true),
                        PLC_VEICULO = c.String(nullable: false, maxLength: 8),
                    })
                .PrimaryKey(t => t.Id_Veiculo);
            
            CreateTable(
                "dbo.Desocupacao",
                c => new
                    {
                        Id_Desocupacao = c.Int(nullable: false),
                        DATA_SAIDA = c.DateTime(nullable: false),
                        Id_Vaga = c.Int(nullable: false),
                        Id_Veiculo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Desocupacao)
                .ForeignKey("dbo.Estadia", t => t.Id_Desocupacao)
                .ForeignKey("bd_sge_sql.VAG_VAGA", t => t.Id_Vaga)
                .ForeignKey("bd_sge_sql.VEIC_VEICULO", t => t.Id_Veiculo)
                .Index(t => t.Id_Desocupacao)
                .Index(t => t.Id_Vaga)
                .Index(t => t.Id_Veiculo);
            
            CreateTable(
                "dbo.Estadia",
                c => new
                    {
                        Id_Estadia = c.Int(nullable: false, identity: true),
                        VLR_ESTADIA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QTD_OCORRENCIA = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Estadia);
            
            CreateTable(
                "bd_sge_sql.OCU_OCUPACAO",
                c => new
                    {
                        Id_Ocup = c.Int(nullable: false),
                        DATA_ENTRADA = c.DateTime(nullable: false),
                        Id_Setor = c.Int(nullable: false),
                        Id_Vaga = c.Int(nullable: false),
                        Id_Veiculo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Ocup)
                .ForeignKey("bd_sge_sql.SET_SETOR", t => t.Id_Setor)
                .ForeignKey("bd_sge_sql.VAG_VAGA", t => t.Id_Vaga)
                .ForeignKey("bd_sge_sql.VEIC_VEICULO", t => t.Id_Veiculo)
                .ForeignKey("dbo.Estadia", t => t.Id_Ocup)
                .Index(t => t.Id_Setor)
                .Index(t => t.Id_Vaga)
                .Index(t => t.Id_Veiculo)
                .Index(t => t.Id_Ocup);
            
            CreateTable(
                "bd_sge_sql.SET_SETOR",
                c => new
                    {
                        Id_Setor = c.Int(nullable: false, identity: true),
                        Nome_Setor = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id_Setor);
            
            CreateTable(
                "bd_sge_sql.VAG_VAGA",
                c => new
                    {
                        Id_Vaga = c.Int(nullable: false, identity: true),
                        Numero_Vaga = c.String(maxLength: 3),
                        Id_Setor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Vaga)
                .ForeignKey("bd_sge_sql.SET_SETOR", t => t.Id_Setor)
                .Index(t => t.Id_Setor);
            
            CreateTable(
                "bd_sge_sql.USU_USUARIO",
                c => new
                    {
                        Id_Usuario = c.Int(nullable: false, identity: true),
                        MATR_USU = c.String(nullable: false),
                        TEL_USU = c.String(nullable: false),
                        LOGIN_USU = c.String(nullable: false),
                        SENHA_USU = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Usuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("bd_sge_sql.CLI_CLIENTE", "Id_Cliente", "bd_sge_sql.USU_USUARIO");
            DropForeignKey("bd_sge_sql.OCO_OCORRENCIA", "Id_Veiculo", "bd_sge_sql.VEIC_VEICULO");
            DropForeignKey("dbo.Desocupacao", "Id_Veiculo", "bd_sge_sql.VEIC_VEICULO");
            DropForeignKey("dbo.Desocupacao", "Id_Vaga", "bd_sge_sql.VAG_VAGA");
            DropForeignKey("bd_sge_sql.OCU_OCUPACAO", "Id_Ocup", "dbo.Estadia");
            DropForeignKey("bd_sge_sql.OCU_OCUPACAO", "Id_Veiculo", "bd_sge_sql.VEIC_VEICULO");
            DropForeignKey("bd_sge_sql.OCU_OCUPACAO", "Id_Vaga", "bd_sge_sql.VAG_VAGA");
            DropForeignKey("bd_sge_sql.OCU_OCUPACAO", "Id_Setor", "bd_sge_sql.SET_SETOR");
            DropForeignKey("bd_sge_sql.VAG_VAGA", "Id_Setor", "bd_sge_sql.SET_SETOR");
            DropForeignKey("dbo.Desocupacao", "Id_Desocupacao", "dbo.Estadia");
            DropForeignKey("bd_sge_sql.OCO_OCORRENCIA", "Id_Tipo_Ocorrencia", "bd_sge_sql.TIPO_OCORRENCIA");
            DropForeignKey("bd_sge_sql.OCO_OCORRENCIA", "Id_Cliente", "bd_sge_sql.CLI_CLIENTE");
            DropIndex("bd_sge_sql.CLI_CLIENTE", new[] { "Id_Cliente" });
            DropIndex("bd_sge_sql.OCO_OCORRENCIA", new[] { "Id_Veiculo" });
            DropIndex("dbo.Desocupacao", new[] { "Id_Veiculo" });
            DropIndex("dbo.Desocupacao", new[] { "Id_Vaga" });
            DropIndex("bd_sge_sql.OCU_OCUPACAO", new[] { "Id_Ocup" });
            DropIndex("bd_sge_sql.OCU_OCUPACAO", new[] { "Id_Veiculo" });
            DropIndex("bd_sge_sql.OCU_OCUPACAO", new[] { "Id_Vaga" });
            DropIndex("bd_sge_sql.OCU_OCUPACAO", new[] { "Id_Setor" });
            DropIndex("bd_sge_sql.VAG_VAGA", new[] { "Id_Setor" });
            DropIndex("dbo.Desocupacao", new[] { "Id_Desocupacao" });
            DropIndex("bd_sge_sql.OCO_OCORRENCIA", new[] { "Id_Tipo_Ocorrencia" });
            DropIndex("bd_sge_sql.OCO_OCORRENCIA", new[] { "Id_Cliente" });
            DropTable("bd_sge_sql.USU_USUARIO");
            DropTable("bd_sge_sql.VAG_VAGA");
            DropTable("bd_sge_sql.SET_SETOR");
            DropTable("bd_sge_sql.OCU_OCUPACAO");
            DropTable("dbo.Estadia");
            DropTable("dbo.Desocupacao");
            DropTable("bd_sge_sql.VEIC_VEICULO");
            DropTable("bd_sge_sql.TIPO_OCORRENCIA");
            DropTable("bd_sge_sql.OCO_OCORRENCIA");
            DropTable("bd_sge_sql.CLI_CLIENTE");
        }
    }
}

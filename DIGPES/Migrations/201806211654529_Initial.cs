namespace DIGPES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avaliacao",
                c => new
                    {
                        AvaliacaoID = c.Int(nullable: false, identity: true),
                        OrdemServico = c.Int(nullable: false),
                        Produto = c.String(nullable: false, maxLength: 20),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Data = c.DateTime(nullable: false),
                        QuestaoA = c.Byte(nullable: false),
                        QuestaoB = c.String(maxLength: 30),
                        QuestaoC = c.String(maxLength: 30),
                        QuestaoD = c.String(maxLength: 30),
                        MotivoQuestaoD = c.String(maxLength: 255),
                        QuestaoE = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.AvaliacaoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Avaliacao");
        }
    }
}

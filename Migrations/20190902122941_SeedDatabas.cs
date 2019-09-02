using esercizioUnikey.Core.Model;
using Microsoft.EntityFrameworkCore.Migrations;

namespace esercizioUnikey.Migrations
{
    public partial class SeedDatabas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            #region InsertCompany
            migrationBuilder.Sql(@"INSERT INTO Company(Email,Name,Password,Profile,DatadiFondazione,TechType) 
                                    VALUES('provacompany1@gmail.com','ProvaCompany1','password123'," + (int)ProfileType.isCompany + ",'2019-09-02'," + (int)TechType.DotNet + ")");
            migrationBuilder.Sql(@"INSERT INTO Company(Email,Name,Password,Profile,DatadiFondazione,TechType) 
                                    VALUES('provacompany2@gmail.com','ProvaCompany2','password123'," +(int) ProfileType.isCompany + ",'2019-09-02'," + (int)TechType.Java + ")");
            migrationBuilder.Sql(@"INSERT INTO Company(Email,Name,Password,Profile,DatadiFondazione,TechType) 
                                    VALUES('provacompany3@gmail.com','ProvaCompany3','password123'," +(int) ProfileType.isCompany + ",'2019-09-02'," +(int) TechType.Sql + ")");
            #endregion

            #region InsertDipendente
            migrationBuilder.Sql(@"INSERT INTO Dipendente(DataAssunzione,Name,CompanyId)
                                     VALUES('2019-09-02','ProvaDipendente1',(SELECT ID FROM Company WHERE TechType=0))");
            migrationBuilder.Sql(@"INSERT INTO Dipendente(DataAssunzione,Name,CompanyId)
                                     VALUES('2019-09-02','ProvaDipendente2',(SELECT ID FROM Company WHERE TechType=1))");
             migrationBuilder.Sql(@"INSERT INTO Dipendente(DataAssunzione,Name,CompanyId)
                                     VALUES('2019-09-02','ProvaDipendente3',(SELECT ID FROM Company WHERE TechType=2))");
            #endregion

            #region InsertPersona
             migrationBuilder.Sql(@"INSERT INTO Persona(Email,Name,Password,Profile,Indirizzo,Azienda)
                                    VALUES('provacompany1@gmail.com','ProvaPersona1','password123'," + (int)ProfileType.isPerson + ",'IndirizzoProva1','AziendaProva1')");
            migrationBuilder.Sql(@"INSERT INTO Persona(Email,Name,Password,Profile,Indirizzo,Azienda)
                                    VALUES('provacompany2@gmail.com','ProvaPersona2','password123'," + (int)ProfileType.isPerson + ",'IndirizzoProva2','AziendaProva2')");
            migrationBuilder.Sql(@"INSERT INTO Persona(Email,Name,Password,Profile,Indirizzo,Azienda)
                                    VALUES('provacompany3@gmail.com','ProvaPersona3','password123'," + (int)ProfileType.isPerson + ",'IndirizzoProva3','AziendaProva3')");
             #endregion

            #region InsertOrdine
             migrationBuilder.Sql(@"INSERT INTO Ordine(DataCreazione,PersonaId)
                                    VALUES('2019-09-02',(SELECT ID FROM Persona WHERE Name='ProvaPersona1'))");
             migrationBuilder.Sql(@"INSERT INTO Ordine(DataCreazione,PersonaId)
                                    VALUES('2019-10-02',(SELECT ID FROM Persona WHERE Name='ProvaPersona2'))");
            migrationBuilder.Sql(@"INSERT INTO Ordine(DataCreazione,PersonaId)
                                    VALUES('2019-11-02',(SELECT ID FROM Persona WHERE Name='ProvaPersona3'))");
            #endregion

            #region InsertProdotto
            migrationBuilder.Sql(@"INSERT INTO Prodotto(Nome,Prezzo,OrdineId)
                                    VALUES('ProdottoNome1',20,(SELECT ID FROM Ordine WHERE DataCreazione='2019-09-02'))");
            migrationBuilder.Sql(@"INSERT INTO Prodotto(Nome,Prezzo,OrdineId)
                                    VALUES('ProdottoNome2',21,(SELECT ID FROM Ordine WHERE DataCreazione='2019-10-02'))");
            migrationBuilder.Sql(@"INSERT INTO Prodotto(Nome,Prezzo,OrdineId)
                                    VALUES('ProdottoNome3',22,(SELECT ID FROM Ordine WHERE DataCreazione='2019-11-02'))");
            #endregion

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Company");
            migrationBuilder.Sql("DELETE FROM Dipendente");
            migrationBuilder.Sql("DELETE FROM Persona");
            migrationBuilder.Sql("DELETE FROM Ordine");
            migrationBuilder.Sql("DELETE FROM Prodotto");
            
        }
    }
}

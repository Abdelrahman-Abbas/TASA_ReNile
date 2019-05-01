using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Company
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public int InsertFarm(string ID, string Size, string City, string FarmState, string Automated, string PH, string DO)
        {
            string query = "INSERT INTO FishFarm " +
                            "Values ('" + ID + "'," + Size + ",'" + City + "','" + FarmState + "','" + Automated + "'," + PH + "," + DO + ");";

            return dbMan.UpdateData(query);
        }

        public int UpdateFishType(string FType, string ID)
        {
            string query = "UPDATE FishType SET FTYPE='" + FType + "' WHERE ID='" + ID + "';";
            return dbMan.UpdateData(query);
        }

        public DataTable ViewAllFarms()
        {

            string query = "SELECT * FROM FishFarm;";
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable DoctorView(string ID)
        {

            string query = "CREATE VIEW DoctorView AS SELECT PH, DO,FarmState,AUTOMATED FROM FishFarm where ID='"+ ID +"';";
            return dbMan.ExecuteTableQuery(query);
        }
        //update:
        public int UpdateFarm(string ID , string FSize, string FCity, string FState, string FAuto, string FPH, string FDO)
        {
            string query = "UPDATE FishFarm SET SIZE='" + FSize + " ', CITY = '"+ FCity +"', FarmState = "+ FState +  "', AUTOMATED= ' "+FAuto+"', PH =" +FPH+ "', DO= '"+DO+
            "' WHERE ID ='" + FID + "';";
            return dbMan.UpdateData(query);
        }
        //Update:
        public int InsertDoctor(string DID, string DFName, string DLName , string DAddress, string DPhone)
        {
            string query = "INSERT INTO FishFarm " +
                            "Values ('" + DID + "'," + DFName + ",'" + DLName + "','" + DAddress + "','" + DPhone + ");";

            return dbMan.UpdateData(query);
        }
        public int DeleteFarm(string FID)
        {
            string query = "DELETE FROM FishFarm WHERE ID ='" + FID + "' ON DELETE SET NULL;";
            return dbMan.UpdateData(query);
        }
//
        public int InsertImporter(string IFAccount, string IName, string Manu, string PType)
        {
            string query = "INSERT INTO Importers " +
                            "Values ('" + IFAccount + "'," + IName + ",'" + Manu + "','" + PType +"');";

            return dbMan.UpdateData(query);
        }
//
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}
// zahar 3ndak wla la2 ya 3bka

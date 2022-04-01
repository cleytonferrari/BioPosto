using System;
using System.Data;
using System.Data.OleDb;
using GrFingerXLib;
using System.Runtime.InteropServices;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;
using BioPosto;

// the template class
public class TTemplate
{
    // Template data.
    public System.Array _tpt;
    // Template size
    public int _size;

    public TTemplate()
    {
        // Create a byte buffer for the template
        _tpt = new byte[(int)GRConstants.GR_MAX_SIZE_TEMPLATE];
        _size = 0;
    }
}

// the database class
public class DBClass
{

    // the connection object
    private FbConnection _connection;

    // temporary template for retrieving data from DB
    private TTemplate tptBlob;

    public DBClass()
    {
    }

    // Open connection
    public bool openDB()
    {
        clsBancoDados conn = new clsBancoDados();
        _connection = conn.retornaConn();
        tptBlob = new TTemplate();
        return true;
    }//END

    // Close conection
    public bool closeDB()
    {
        if (_connection.State != ConnectionState.Closed)
            _connection.Close();
        return true;
    }

    // Add template to database. Returns added template ID.
    public bool addTemplate(TTemplate tpt, string campo, string id)
    {
        FbCommand cmdInsert = null;
        FbParameter dbParamInsert = null;

        try
        {
            // Create SQL command containing ? parameter for BLOB.
            cmdInsert = new FbCommand("UPDATE cliente SET " + campo + " = @template WHERE cliente_id = "+ id, _connection);
            // Create parameter for ? contained in the SQL statement.
            System.Byte[] temp = new System.Byte[tpt._size + 1];
            System.Array.Copy(tpt._tpt, 0, temp, 0, tpt._size);

           // dbParamInsert = new FbParameter("@template", FbDbType.Binary, tpt._size,
           //                 ParameterDirection.Input, false, 0, 0, "cliente_id",
           //                 DataRowVersion.Current, temp);

            cmdInsert.Parameters.Add("@template",temp);

            //execute query
            if (_connection.State == ConnectionState.Open)
                cmdInsert.ExecuteNonQuery();
        }
        catch
        {
            return false;
        }

        return true;
    }

    // Returns an OleDbDataReader with all enrolled templates from database.
    public FbDataReader getTemplates()
    {
        FbCommand cmdGetTemplates;
        FbDataReader rs;

        //setting up command 
        cmdGetTemplates = new FbCommand("SELECT * FROM cliente", _connection);
        rs = cmdGetTemplates.ExecuteReader();

        return rs;
    }




    // Return template data from an OleDbDataReader
    public TTemplate getTemplate(FbDataReader rs, int idCampo)
    {
        long readedBytes;
        tptBlob._size = 0;
        // alloc space
        System.Byte[] temp = new System.Byte[
            (int)GRConstants.GR_MAX_SIZE_TEMPLATE];
        try
        {
            // get bytes
            //INDICE DO CAMPO NO BANCO DE DADOS, começa do ZERO
            //neste caso bio1 24, bio2 25
            readedBytes = rs.GetBytes(idCampo, 0, temp, 0, temp.Length);
            // copy to structure
            System.Array.Copy(temp, 0, tptBlob._tpt, 0, (int)readedBytes);
            // set real size
            tptBlob._size = (int)readedBytes;
            return tptBlob;
        }
        catch
        {
            //caso o template seja NULO no banco de dados retorna -1
            //para que a função que chamou saiba que o campo é nullo
            tptBlob._size = -1;
            return tptBlob;
        }
    }

    // Return enrollment ID from an OleDbDataReader
    public int getId(FbDataReader rs)
    {
        return rs.GetInt32(0);
    }
}

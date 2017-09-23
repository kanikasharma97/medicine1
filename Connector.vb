Imports System.Data.SqlClient
Module Connector
    Dim connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB; Database=C:\Users\kanika\Documents\GetWellmedsdatabase.mdf;")
    Dim sqlAdp As SqlDataAdapter

    Dim cmd As SqlCommand

    Function read(query As String)
        connection.Open()
        sqlAdp = New SqlDataAdapter(query, connection)
        connection.Close()
        Dim ds As New DataSet
        sqlAdp.Fill(ds)
        Return ds
    End Function

    Function readColumn(tableName As String, columnName As String)
        Dim query As String
        query = "select " + columnName + " from " + tableName
        Dim ds As DataSet
        ds = read(query)

        Dim list As List(Of Object) = New List(Of Object)

        For Each Row As DataRow In ds.Tables(0).Rows
            list.Add(Row.Item(0))
        Next
        Return list
    End Function

    Function write(tableName As String, values As List(Of Object))
        Dim query As String = "insert into " + tableName + " values("
        Dim val As String
        Dim retunrVal As Integer
        Dim iterationCount As Integer = 0

        For Each val In values
            iterationCount += 1
            If (iterationCount = values.Count) Then
                query += "'" + val + "'"
            Else
                query += "'" + val + "',"
            End If
        Next

        query += ")"

        connection.Open()
        cmd = New SqlCommand(query, connection)
        retunrVal = cmd.ExecuteNonQuery()
        connection.Close()
        Return retunrVal
    End Function

    Function delete(table As String, colName As String, value As Object)
        Dim query As String = "Delete from " + table + " where " + colName + "= '" + value + "'"
        Dim returnVal As Integer
        connection.Open()
        cmd = New SqlCommand(query, connection)
        returnVal = cmd.ExecuteNonQuery()
        connection.Close()
        Return returnVal
    End Function


    Function updateTable(tableName As String, colName As String, colValue As String, values As List(Of Object))
        delete(tableName, colName, colValue)
        write(tableName, values)
    End Function

    Function executeUpdateQuery(query As String)
        Dim retunrVal As Integer
        connection.Open()
        cmd = New SqlCommand(query, connection)
        retunrVal = cmd.ExecuteNonQuery()
        connection.Close()
    End Function
End Module


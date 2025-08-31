<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="MyApplication.CRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book CRUD</title>
    <style>
        body {
            background-color: #f8f9fa;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            margin: 0;
            padding: 0;
        }

        form {
            display: flex;
            justify-content: center;
            align-items: flex-start;
            padding-top: 40px;
        }

        .container {
            background-color: #fff;
            padding: 30px 40px;
            border-radius: 10px;
            box-shadow: 0 8px 20px rgba(0, 0, 0, 0.1);
            width: 600px;
        }

        .container h2 {
            text-align: center;
            margin-bottom: 25px;
            color: #343a40;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-group label {
            display: inline-block;
            width: 120px;
            font-weight: bold;
            color: #495057;
        }

        .form-group input[type="text"] {
            width: calc(100% - 130px);
            padding: 8px;
            border: 1px solid #ced4da;
            border-radius: 5px;
        }

        .form-group input[readonly] {
            background-color: #e9ecef;
        }

        .form-actions {
            margin-top: 20px;
            text-align: center;
        }

        .form-actions input[type="submit"],
        .form-actions input[type="button"] {
            margin: 0 10px 10px 0;
            padding: 8px 16px;
            font-size: 14px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        #bAdd {
            background-color: #28a745;
            color: white;
        }

        #bUpdate {
            background-color: #007bff;
            color: white;
        }

        #bDelete {
            background-color: #dc3545;
            color: white;
        }

        #bCancel {
            background-color: #6c757d;
            color: white;
        }

        #LResult {
            display: block;
            text-align: center;
            margin-top: 10px;
            color: #007bff;
        }

        .gridview-container {
            margin-top: 40px;
        }

        .gridview-container asp\:GridView {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Manage Books</h2>

            <asp:Label ID="lbID" runat="server" Text="ID" Visible="False"></asp:Label>
            <asp:TextBox ID="tbID" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>

            <div class="form-group">
                <label for="tbBookName">Book Name</label>
                <asp:TextBox ID="tbBookName" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="tbPrice">Price</label>
                <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="tbDescreption">Description</label>
                <asp:TextBox ID="tbDescreption" runat="server"></asp:TextBox>
            </div>

            <asp:Label ID="LResult" runat="server"></asp:Label>

            <div class="form-actions">
                <asp:Button ID="bAdd" runat="server" Text="Add" OnClick="bAdd_Click" />
                <asp:Button ID="bUpdate" runat="server" Text="Update" OnClick="bUpdate_Click" Visible="False" />
                <asp:Button ID="bDelete" runat="server" Text="Delete" OnClick="bDelete_Click" Visible="False" />
                <asp:Button ID="bCancel" runat="server" Text="Cancel" OnClick="bCancel_Click" />
            </div>

            <div class="gridview-container">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                    BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px"
                    CellPadding="3" CellSpacing="1" GridLines="None" Width="100%">
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>

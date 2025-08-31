<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        body {
            background-color: #e9ecef;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            margin: 0;
            padding: 0;
        }

        form {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .login-container {
            background-color: #ffffff;
            padding: 40px 35px;
            border-radius: 12px;
            box-shadow: 0 10px 25px rgba(0, 0, 0, 0.1);
            width: 360px;
        }

        .login-container h2 {
            text-align: center;
            margin-bottom: 25px;
            color: #343a40;
        }

        .aspNet-Login {
            display: flex;
            flex-direction: column;
        }

        .aspNet-Login label {
            margin-bottom: 5px;
            font-weight: bold;
            color: #495057;
        }

        .aspNet-Login input[type="text"],
        .aspNet-Login input[type="password"] {
            padding: 10px;
            font-size: 14px;
            border: 1px solid #ced4da;
            border-radius: 5px;
            margin-bottom: 20px;
            transition: border-color 0.3s;
        }

        .aspNet-Login input[type="text"]:focus,
        .aspNet-Login input[type="password"]:focus {
            border-color: #80bdff;
            outline: none;
        }

        .aspNet-Login input[type="submit"],
        .aspNet-Login button {
            background-color: #007bff;
            border: none;
            color: white;
            padding: 10px;
            font-size: 15px;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .aspNet-Login input[type="submit"]:hover,
        .aspNet-Login button:hover {
            background-color: #0056b3;
        }

        .aspNet-Login span {
            color: red;
            font-size: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <asp:Login ID="LoginPage" runat="server" OnAuthenticate="Login1_Authenticate" CssClass="aspNet-Login">
            </asp:Login>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MyBlogs.Site.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>博客后台登陆</title>
    <style type="text/css">
        * {
            margin: 0;
            padding: 0;
        }

        #logindiv {
            border: 1px solid #0094ff;
            width: 300px;
            margin: 0 auto;
            margin-top: 45px;
        }

        #top {
            width: 300px;
            height: 45px;
            background-color: #0094ff;
            margin: 0 auto;
            font-size:28px;
            padding-top:8px;
            color:white;
        }

        #login {
            width: 300px;
            height: 500px;
            margin: 0 auto;
            margin-top: 20px;
        }
    </style>
</head>
    <%--✔--%>
<body>
    <form id="formlogin" method="post" runat="server">
        <div id="logindiv">
            <div id="top">
                <span>后台登陆</span>
            </div>
            <div id="login">
                <div id="user">
                    <span style="color:red;padding-right:2px;">*</span><span style="padding-right:10px;">用户名</span><input type="text" id="nametext" name="username"   /><span></span>
                </div>
                <div id="pwd" style="padding-top:10px;">
                    <span style="color:red;padding-right:2px;">*</span><span style="padding-right:10px">密<span style="padding:9px;"></span >码</span><input type="password" id="password" name="password"  /><span></span>
                </div>
            </div>
        </div>

    </form>
</body>
</html>

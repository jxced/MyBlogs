<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="MyBlogs.Site._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        *{
            margin:0;
            padding:0;
        }
        #blogPage_top,#blogPage_body,#blogPage_bottom{
            margin:0 auto;
            border:1px solid #0094ff;
            min-width:960px;
            width:960px;
            margin-top:5px;
        }
        #top_span{
            /*padding-right:10px;*/
            /*padding-left:760px;*/
            /*vertical-align:middle;*/
            float:right;
            padding:7px;
        }
        #top_span span{
            font-size: 18px;
            font-weight:bold;
            color:#0094ff;
        }
        a{
            text-decoration:none;
            color:#0094ff;
        }
        a:hover{
            color:#ff6a00;
        }
    </style>
</head>
<body>
    <%--<form id="form1" runat="server">
        <div>
        </div>
    </form>--%>
        <div id="blogPage_top" style="min-height:35px; height:35px;">
        <span id="top_span">
            <span ><a href="#">登陆</a></span>
            <span ><a href="#">返回博客首页</a></span>
            <span ><a href="#">退出</a></span>
        </span>
    </div>
    <div id="blogPage_body">body</div>
    <div id="blogPage_bottom">bottom</div>
    
</body>
</html>

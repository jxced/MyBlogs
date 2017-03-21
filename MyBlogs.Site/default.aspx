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
            list-style:none;
            border:0;
        }
        #blogPage_body{
            height:auto;
            min-height:695px;
        }
        #blogPage_top,#blogPage_body,#blogPage_bottom{
            margin:0 auto;
            border:1px solid #0094ff;
            min-width:960px;
            width:960px;
            margin-top:5px;
        }
       
        #body_title{
            min-height:35px;
            height:35px; 
            background-color:#0094ff;
            font-size:30px;color:#ffffff;
            vertical-align:middle;
        }
        #blogPage_bottom{
             color:white;
             font-size:20px;
             text-align:center;
             background-color:#0094ff;
             height:30px;
            
        }
       
        #body_menu,#body_content{
            margin:4px;
            border:1px dashed #808080;
            height:650px;
            min-height:650px;
        }
        #body_menu{
            float:left;
            width:22%;
            
        }
        #body_content{
            float:right;
            width:75%;
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
        .li_top{
            font-size:20px;
            background-color:#c2bfbf;
        }
        .li_1,.li_2{
            padding-left:10px;
            background-color:#dddbdb;
        }
        #table{
            display:table;
            border-collapse:collapse;
            border:2px solid #000000;
        }
        #table li{
            float:right;
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
    <div id="blogPage_body">
        <div id="body_title" >
            博客后台管理
        </div>
        <div id="body_menu">
            <ul>
                <li class="li_top"><a href="javascript:void(0);" onclick="#">日志管理</a></li>
                <li class="li_1"><a href="javascript:void(0);" onclick="#">文章分类管理</a></li>
                <li class="li_1"><a href="javascript:void(0);" onclick="#">文章管理</a></li>
            </ul>
            <ul>
                <li class="li_top"><a href="javascript:void(0);" onclick="#">相册管理</a></li>
                <li class="li_2"><a href="javascript:void(0);" onclick="#">相册列表</a></li>
                <li class="li_2"><a href="javascript:void(0);" onclick="#">上传照片</a></li>
            </ul>
        </div>
        <div id="body_content">
            <div id="table">
                <div id="title">
                    <ul >
                        <li>序号</li>
                        <li>姓名</li>
                        <li>年龄</li>
                        <li>备注</li>
                    </ul>
                </div>
                
            </div>
        </div>
    </div>
    <div id="blogPage_bottom">
        <span>版权所有</span>
    </div>
    
</body>
</html>

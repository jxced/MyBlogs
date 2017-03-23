<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="MyBlogs.Site._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="/style/tableStyle.css" rel="stylesheet" />
    <link href="style/defaultStyle.css" rel="stylesheet" />
    <script src="/script/jquery-1.9.1.js"></script>
    <script type="text/javascript">
        XMLHttpRequest
        $(function () {
            $("#chkAll").click(function () {
                var isChk = this.checked;
                $("input[name='chk']").each(function () {
                    this.checked = isChk;
                });
            });
        });
        function hidd(className) {
            $(className).toggle();
        }
        function edit() {

        }
    </script>
</head>
<body>
    <%--<form id="form1" runat="server">
        <div>
        </div>
    </form>--%>
    <div id="blogPage_top" style="min-height: 35px; height: 35px;">
        <span id="top_span">
            <span><a href="#">登陆</a></span>
            <span><a href="#">返回博客首页</a></span>
            <span><a href="#">退出</a></span>
        </span>
    </div>
    <div id="blogPage_body">
        <div id="body_title">
            博客后台管理
        </div>
        <div id="body_menu">
            <ul>
                <li class="li_top"><a href="javascript:void(0);" onclick="hidd('.li_1')">日志管理</a></li>
                <li class="li_1"><a href="javascript:void(0);" onclick="#">文章分类管理</a></li>
                <li class="li_1"><a href="javascript:void(0);" onclick="#">文章管理</a></li>
            </ul>
            <ul>
                <li class="li_top"><a href="javascript:void(0);" onclick="hidd('.li_2')">相册管理</a></li>
                <li class="li_2"><a href="javascript:void(0);" onclick="#">相册列表</a></li>
                <li class="li_2"><a href="javascript:void(0);" onclick="#">上传照片</a></li>
            </ul>
        </div>
        <div id="body_content">
            <form action="/default.aspx" method="post">
                <div id="editTable" hidden="hidden" style="position:absolute;left:300px;right:400px;">
                    <div class="table-column-group">
                        <div class="table-column" style="width: 45px;"></div>
                        <div class="table-column" style="width: 45px;"></div>
                        <div class="table-column"></div>
                        <div class="table-column"></div>
                        <div class="table-column" style="width: 150px;"></div>
                        <div class="table-column"></div>
                        <div class="table-column"></div>
                    </div>
                    <div class="table-header-group">
                        <ul class="table-row">
                            <li class="table-cell">
                            <li class="table-cell">序号</li>
                            <li class="table-cell">作者</li>
                            <li class="table-cell">分类名称</li>
                            <li class="table-cell">备注</li>
                            <li class="table-cell">状态</li>
                        </ul>
                    </div>
                </div>
                <div id="operate">
                    <input type="button" value="新增" onclick="" />
                    <input type="submit" value="批量删除" />
                </div>
                <div class="table">
                    <div class="table-column-group">
                        <div class="table-column" style="width: 45px;"></div>
                        <div class="table-column" style="width: 45px;"></div>
                        <div class="table-column"></div>
                        <div class="table-column"></div>
                        <div class="table-column" style="width: 150px;"></div>
                        <div class="table-column"></div>
                        <div class="table-column"></div>
                    </div>
                    <div class="table-header-group">
                        <ul class="table-row">
                            <li class="table-cell">
                                <input id="chkAll" type="checkbox" name="chkAll"  /></li>
                            <li class="table-cell">序号</li>
                            <li class="table-cell">作者</li>
                            <li class="table-cell">分类名称</li>
                            <li class="table-cell">备注</li>
                            <li class="table-cell">状态</li>
                            <li class="table-cell">操作</li>
                        </ul>
                    </div>
                    <%=responsestr %>
                    <%-- <div class="table-footer-group">
                    <ul class="table-row">
                        <li class="table-cell">备注</li>
                        <li class="table-cell">footer</li>
                        <li class="table-cell">footer</li>
                        <li class="table-cell">footer</li>
                        <li class="table-cell">footer</li>
                        <li class="table-cell">footer</li>
                    </ul>
                </div>
                <div class="table-row-group">
                    <ul class="table-row">
                        <li class="table-cell">
                            <input type="checkbox" /></li>
                        <li class="table-cell">John</li>
                        <li class="table-cell">19</li>
                        <li class="table-cell">1</li>
                        <li class="table-cell">John</li>
                        <li class="table-cell">19</li>
                    </ul>
                    <ul class="table-row">
                        <li class="table-cell">
                            <input type="checkbox" /></li>
                        <li class="table-cell">Mark</li>
                        <li class="table-cell">21</li>
                        <li class="table-cell">2</li>
                        <li class="table-cell">Mark</li>
                        <li class="table-cell">21</li>
                    </ul>
                    <ul class="table-row">
                        <li class="table-cell">
                            <input type="checkbox" /></li>
                        <li class="table-cell">Kate</li>
                        <li class="table-cell">26</li>
                        <li class="table-cell">3</li>
                        <li class="table-cell">Kate</li>
                        <li class="table-cell">26</li>
                    </ul>
                </div>--%>
                </div>

            </form>

        </div>
    </div>
    <div id="blogPage_bottom">
        <span>版权所有</span>
    </div>

</body>
</html>

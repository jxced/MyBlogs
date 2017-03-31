<%@ Page Title="" Language="C#" MasterPageFile="~/master/blogs.Master" AutoEventWireup="true" CodeBehind="blogsList.aspx.cs" Inherits="MyBlogs.Site.blogsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/script/jquery-1.9.1.js"></script>
    <script type="text/javascript">

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
        //$(function edit() {
        //    var xhr = new XMLHttpRequest();
        //    xhr.open("get", "articleHandler.ashx?type=loadList", true);
        //    xhr.onreadystatechange = function () {

        //    };
        //    xhr.send(null);
        //    $.get("", function () { }, JSON);
        //})
    </script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <form action="/default.aspx" method="post">
                <div id="editTable" hidden="hidden" style="position: absolute; left: 300px; right: 400px;">
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
                                <input id="chkAll" type="checkbox" name="chkAll" /></li>
                            <li class="table-cell">序号</li>
                            <li class="table-cell">作者</li>
                            <li class="table-cell">分类名称</li>
                            <li class="table-cell">备注</li>
                            <li class="table-cell">状态</li>
                            <li class="table-cell">操作</li>
                        </ul>
                    </div>
                    <script  type="text/javascript">
                        $(function () {
                            $.getJSON("/actions/articleHandler.ashx?type=loadList", function (jsObj) {
                                var obj = JSON.parse(jsObj);
                                $.each(obj.Datas, function () {
                                    
                                });
                            });
                        })

                    </script>
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
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageCG.Master" AutoEventWireup="true" CodeBehind="Receita_detalhe_CG.aspx.cs" Inherits="CHEF_GATO_WEB2.Receita_detalhe_CG" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <div>
            <br />


            <h1>
                <asp:Label ID="nome_lbl" runat="server" Text="Label"></asp:Label></h1>
            <br />
            <h6>
                <asp:TextBox ID="Voto_txb" runat="server"></asp:TextBox></h6>

            <br />
            <br />
            <br />
            <div class="row">
                <div class="column" style="padding-left: 15px">
                    <asp:Label ID="categoria" runat="server" CssClass="form-control" Style="width: 200px" BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black"></asp:Label>

                    <br />
                    <asp:Label ID="doses" runat="server" CssClass="form-control" Style="width: 200px" BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black"></asp:Label>


                    <br />
                    <asp:Label ID="dificuldade" runat="server" CssClass="form-control" Style="width: 200px" BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black"></asp:Label>
                    <br />
                    <asp:Label ID="tempo_exec" runat="server" CssClass="form-control" Style="width: 200px" BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black"></asp:Label>
                    <br />
                    <asp:Label ID="autor" runat="server" CssClass="form-control" Style="width: 200px" BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black"></asp:Label>
                    <br />
                    <br />
                </div>
            </div>
            <div class="column">
                <asp:GridView ID="GridView1" runat="server" CssClass="table-bordered" BackColor="Black" Style="margin-left: 150px" ForeColor="Black" OnRowDataBound="GridView_RowDataBound">
                    <EditRowStyle HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#CCCCCC" Font-Bold="True" HorizontalAlign="Center" />
                    <RowStyle HorizontalAlign="Center" />
                </asp:GridView>
            </div>
            <div class="column">
                <asp:Image ID="Image1" runat="server" Style="width: 300px; height: 300px; border: 1px solid black; border-radius: 5px; position: absolute; top: 450px; right: 100px" />
            </div>
        </div>
        <br />
            <div class="form-control" style="width: 500px; padding-left: 2em; padding-top: 1em; padding-bottom: 1em;">
                <asp:Label ID="Preparacao" runat="server"></asp:Label>
            </div>
            <hr class="rounded" style="border-top: 8px solid; color: gray; border-radius: 5px">
            <br />
    </form>

</asp:Content>

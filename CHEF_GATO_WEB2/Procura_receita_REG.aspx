<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Registados.Master" AutoEventWireup="true" CodeBehind="Procura_receita_REG.aspx.cs" Inherits="CHEF_GATO_WEB2.Procura_receita_REG" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <form id="form1" runat="server">
        <br />

        <h1>Procura de Receitas</h1>
        <br />

        <asp:Label ID="Label1" runat="server" Text="Por Nome"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Procurar" OnClick="Button1_Click" />

        <br />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Por Ingrediente"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Procurar" OnClick="Button2_Click1" />

        <br />
        <br />

        <asp:Label ID="Label3" runat="server" Text="Por Categoria"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Text="Procurar" />

        <br />

        <br />

        <br />

        <asp:Image ID="Image1" runat="server" ImageUrl="~/IMAGENS/sem_resultados.png" Visible="False" Width="350px" />

        <br />
        <asp:Button ID="VerTodas" runat="server" Text="Ver Todas as Receitas" OnClick="Button_VerTodas_Click1" />
     
        <br />
        <hr />
        <br />

        <br />
        
        <div class="row">

            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand1">
                <ItemTemplate>
                    <div class="col-lg-4 col-md-4 col-sm-4">

                        <div class="card text-white bg-secondary mb-3" style="max-width: 20rem; height: 220px; margin: 8px 8px 8px 8px">

                            <div class="card-text" style="margin-left: 15px">
                                <h1><%# Eval("Nome") %></h1>
                                <img src='data:Image/png;base64,<%# Eval("Foto") != System.DBNull.Value ? Convert.ToBase64String((byte[])Eval("Foto")) : string.Empty %>'alt="image" height="80" width="80" style="border:1px solid black; position:absolute; bottom:10px;  left:15px" />
                                <asp:Button ID="Button4" runat="server" style="position:absolute; bottom:10px; right:15px" Text="Ver"  OnClick="Button4_Click" CommandArgument='<%# Eval("Recid") %>' /> 
                            </div>


                          
                        </div>

                    </div>
                </ItemTemplate>

            </asp:Repeater>
        </div>

        <br />

    </form>

</asp:Content>

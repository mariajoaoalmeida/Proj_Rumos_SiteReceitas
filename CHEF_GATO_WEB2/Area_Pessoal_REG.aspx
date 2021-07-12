<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Registados.Master" AutoEventWireup="true" CodeBehind="Area_Pessoal_REG.aspx.cs" Inherits="CHEF_GATO_WEB2.Area_Pessoal_REG" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formap" runat="server" visible="True">


        <br />
        <asp:Image ID="Image2" runat="server" Height="67px" ImageUrl="~/IMAGENS/chef gato_uti.png" Width="58px" />


        <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black" BorderStyle="None"></asp:TextBox>
        <br />
        <br />
        <div class="row">
            <div class="column" style="padding-left: 15px">

                <asp:Button ID="Mudar_email_inicio" runat="server" Height="60px" OnClick="Mudar_email_inicio_Click" Text="Alterar e-mail" Width="250px" />
                <br />
                <br />

                <%# Eval("Nome") %>
                <asp:Label ID="Label3" runat="server"  Text="Email Actual" Visible="False"></asp:Label>
                <asp:TextBox ID="email_tbx" runat="server"  Visible="False"></asp:TextBox>




                <br />
                <asp:Label ID="Label4" runat="server" Text="Novo e-mail"  Visible="False"></asp:Label>
                <asp:TextBox ID="novo_email_txb" runat="server"  Visible="False"></asp:TextBox>
                <br />
                <asp:TextBox ID="resultado_email_txb" runat="server" BorderStyle="None"  Font-Bold="True" Visible="False" Width="747px"></asp:TextBox>
                <br />
                <asp:Button ID="Alterar_email_fim_btn" runat="server" OnClick="Alterar_email_btn_Click"  Text="Alterar" Visible="False" />
                <br />
            </div>
            <div class="column" style="padding-left: 100px">

                <asp:Button ID="Alterar_pass_inicio" runat="server" CssClass="btn btn-outline-primary"  Text="Alterar Password" OnClick="Button2_Click" Height="60px" Width="250px" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Password Actual"  Visible="False"></asp:Label>
                <asp:TextBox ID="AntigaPass_txb" runat="server" Visible="False"  TextMode="Password"></asp:TextBox>
                <br />

                <asp:Label ID="Label2" runat="server" Text="Nova Password"  Visible="False"></asp:Label>
                <asp:TextBox ID="NovaPass_txb" runat="server" Visible="False"  TextMode="Password" OnTextChanged="NovaPass_txb_TextChanged"></asp:TextBox>
                <br />




                <asp:TextBox ID="Msg" runat="server" Visible="False" BorderStyle="None" Font-Bold="True" Width="732px"></asp:TextBox>




                <br />
                <asp:Button ID="Alterar_pass_fim_btn" runat="server" Text="Alterar" OnClick="Alterar_btn_Click" Visible="False" />
                <br />
            </div>
        </div>
        <br />
        <asp:Button ID="Button3" runat="server" CssClass="btn btn-secondary" Text="Ver Receitas Favoritas" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:TextBox ID="resultado_rec_favoritas" runat="server" BorderStyle="None" Visible="False"></asp:TextBox>
        <br />

        <br />

        <div class="row">

            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand1">
                <ItemTemplate>
                    <div class="col-lg-4 col-md-4 col-sm-4">

                        <div class="card text-white bg-secondary mb-3" style="max-width: 20rem; height: 180px; margin: 8px 8px 8px 8px">

                            <div class="card-text" style="margin-left: 15px">
                                <h1><%# Eval("Nome") %></h1>
                                <img src='data:Image/png;base64,<%# Eval("Foto") != System.DBNull.Value ? Convert.ToBase64String((byte[])Eval("Foto")) : string.Empty %>' alt="image" height="80" width="80" style="border: 1px solid black; position: absolute; bottom: 10px; left: 15px" />
                                <asp:Button ID="Button4" runat="server" Style="position: absolute; bottom: 10px; right: 15px" Text="Ver" OnClick="Button4_Click" CommandArgument='<%# Eval("Recid") %>' />
                            </div>



                        </div>

                    </div>
                </ItemTemplate>

            </asp:Repeater>
            <br />
            <br />
        

        </div>
        <asp:Button ID="Button5" runat="server" CssClass="btn btn-secondary" Text="Submeter Receita" PostBackUrl="~/InserirReceita.aspx" OnClick="Button4_Click" Style="margin-left:20px"/>
    </form>
</asp:Content>

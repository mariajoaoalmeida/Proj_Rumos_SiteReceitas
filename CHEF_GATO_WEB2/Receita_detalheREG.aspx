<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Registados.Master" AutoEventWireup="true" CodeBehind="Receita_detalheREG.aspx.cs" Inherits="CHEF_GATO_WEB2.Receita_detalhe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="ReceitaId" runat="server" Visible="False"></asp:TextBox>
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
            <h2>Comentários</h2>
            <br />
            <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand1">
                <ItemTemplate>
                    <div class="col-lg-4 col-md-4 col-sm-4">

                        <div class="card bg-light mb-3" style="max-width: 20rem; height: 190px; margin: 20px 8px 8px 8px">

                            <div class="card-header"><%# Eval("UserName") %> <asp:Image ID="Image2" runat="server" Height="20px" ImageUrl="~/IMAGENS/chef gato.png" Width="20px" /></div>
                            <div class="card-body"><%# Eval("TextoComentario") %></div>


                        </div>


                    </div>
                </ItemTemplate>

            </asp:Repeater>
        </div>
        <br />
        <hr class="rounded" style="border-top: 8px solid; color: gray; border-radius: 5px">
        <br />
        <div class="row">
            <div class="column" style="padding-left: 15px">
                Votar
                <div class="form-control" style="width: 150px; padding-left: 2em; padding-top: 1em; padding-bottom: 1em;">
                    
                    <h6>

                        <asp:RadioButton ID="Excelente" runat="server" GroupName="a" Text="Excelente!" />


                    </h6>
                    <h6>


                        <asp:RadioButton ID="Bom" runat="server" GroupName="a" Text="Bom" />
                    </h6>
                    <h6>

                        <asp:RadioButton ID="Medio" runat="server" GroupName="a" Text="Médio" />
                    </h6>
                    <h6>

                        <asp:RadioButton ID="Mau" runat="server" GroupName="a" Text="Mau" />
                    </h6>
                    <h6>

                        <asp:RadioButton ID="Pessimo" runat="server" GroupName="a" Text="Péssimo!" />
                    </h6>

                </div>
                <br />
<asp:Button ID="Sbmt_voto_btn" runat="server" Text="Submeter Voto" OnClick="Sbmt_voto_btn_Click" />
                <asp:Image ID="Image3" runat="server" Height="40px" ImageUrl="~/IMAGENS/erro_nao_falta_nada.png" Visible="False" Width="117px" />
                <br />
                <asp:TextBox ID="filtro_voto" runat="server" BorderStyle="None" Visible="False" Width="383px"></asp:TextBox>
            </div>
           <div class="column" style="padding-left: 15px">
                <div class="form-group" Style="padding-left:100px">
                  
                
                    
                        Comentar Receita
                       
                        <br />
                        <asp:TextBox ID="Comentario_bx" runat="server" CssClass="form-control" Height="208px" Width="461px"></asp:TextBox>
                 
                 
                        <asp:TextBox ID="cmt_txb" runat="server" Visible="False"></asp:TextBox>
                 
                 
                    <br />
                    <asp:Button ID="Sbmt_Comt_btn" runat="server" OnClick="Sbmt_Comt_btn_Click" Text="Submeter Comentário" />
                        <asp:Image ID="Image4" runat="server" Height="51px" ImageUrl="~/IMAGENS/erro_nao_falta_nada.png" Visible="False" Width="149px" />
                    </div>
                   </div>
            </div>
           <br />
        <br />
        
        <asp:Image ID="Image2" runat="server" Height="38px" ImageUrl="~/IMAGENS/hrt.jpg" Width="45px" />
        <asp:Button ID="Adicionar_fv_btn" runat="server" Text="Adicionar às Minhas Receitas Favoritas" OnClick="Adicionar_fv_btn_Click" />




        <asp:TextBox ID="RF_resultado" runat="server" Visible="False" Width="424px"></asp:TextBox>




    </form>



</asp:Content>

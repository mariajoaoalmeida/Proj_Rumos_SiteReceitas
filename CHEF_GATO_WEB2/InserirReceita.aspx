<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Registados.Master" AutoEventWireup="true" CodeBehind="InserirReceita.aspx.cs" Inherits="CHEF_GATO_WEB2.InserirReceita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 605px;
        }
        .auto-style2 {
            display: block;
            clear: both;
            font-weight: 400;
            color: lightgray;
            text-align: inherit;
            text-decoration: none;
            white-space: nowrap;
            border: 1px solid #333;
            background-color: transparent;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <br />
        <asp:Panel ID="Panel2" Cssclass="card border-primary mb-3" Style="padding: 20px 20px 20px 20px;" runat="server">
            <h2>Inserir Receita</h2>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Nome da Receita"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="599px"></asp:TextBox>
                <asp:Image ID="nome_erro" runat="server" Height="82px" ImageUrl="~/IMAGENS/erro_dado_invalido.png" Width="218px" Visible="False" />
            </p>
            <p id="nome_erro2" class="auto-style1">&nbsp;</p>
            <asp:Label ID="Label9" runat="server" Text="Categoria"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList7" CssClass="auto-style2" Style="border-style: solid; border-width: 2px; border-color: dimgray; border-radius: 25px" Width="281px" runat="server" BackColor="#CCCCCC" ForeColor="Black">
                <asp:ListItem>--- Seleccione ---</asp:ListItem>
            </asp:DropDownList>
            <br />


            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Tempo de Preparação"></asp:Label>



            <br />
            <asp:DropDownList ID="DropDownList5" CssClass="dropdown-item" Style="border-style: solid; border-width: 2px; border-color: dimgray; border-radius: 25px" Width="154px" runat="server" BackColor="#CCCCCC" ForeColor="Black">
                <asp:ListItem>5 min</asp:ListItem>
                <asp:ListItem>10 min</asp:ListItem>
                <asp:ListItem>15 min</asp:ListItem>
                <asp:ListItem>20 min</asp:ListItem>
                <asp:ListItem>30 min</asp:ListItem>
                <asp:ListItem>45 min</asp:ListItem>
                <asp:ListItem>1 h</asp:ListItem>
                <asp:ListItem>1h 30 min</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Nº de Doses"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList6" CssClass="dropdown-item" Style="border-style: solid; border-width: 2px; border-color: dimgray; border-radius: 25px" Width="154px" runat="server" BackColor="#CCCCCC" ForeColor="Black">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>45</asp:ListItem>
                <asp:ListItem>60</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label13" runat="server" Text="Dificuldade"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList9" runat="server" BackColor="#CCCCCC" CssClass="dropdown-list" ForeColor="Black" Height="25px" Width="300px">
                <asp:ListItem>Até o gato faz!</asp:ListItem>
                <asp:ListItem>Fácil</asp:ListItem>
                <asp:ListItem>Assim Assim</asp:ListItem>
                <asp:ListItem>Difícil</asp:ListItem>
                <asp:ListItem>Só para chefs de verdade!</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel1" CssClass="card border-primary mb-3" Style="padding: 20px 20px 20px 20px;" runat="server">

            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Ingredientes"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" Style="border-style: solid; border-width: 2px; border-color: dimgray; border-radius: 25px" Width="188px" runat="server" BackColor="#CCCCCC" ForeColor="Black" Height="56px">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label18" runat="server" Font-Bold="True" ForeColor="Red" Text="Já adicionaste este ingrediente... Apaga e faz uma nova entrada!" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label11" runat="server" Text="Quantidade"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="151px" BackColor="#CCCCCC" Height="42px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;<asp:Image ID="erro_qt" runat="server" Height="77px" ImageUrl="~/IMAGENS/erro_dado_invalido.png" Width="192px" Visible="False" />
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="Unidade de Medida"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList8" CssClass="dropdown-item" runat="server" Width="236px" BackColor="#CCCCCC" ForeColor="Black">
            </asp:DropDownList>

            <br />
            <asp:Button ID="adicionar_ing_btn" runat="server" Text="Adicionar" OnClick="adicionar_ing_btn_Click" Width="189px" />
            <br />
            <br />

            <asp:GridView ID="GridView1" CssClass="table-bordered" runat="server" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:ButtonField ButtonType="Image" CommandName="Delete" ImageUrl="~/IMAGENS/lixo.png" Text="Eliminar" />
                </Columns>
            </asp:GridView>

            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Fechar Lista de ingredientes" Width="367px" BackColor="Silver" />
            &nbsp;
            <asp:Image ID="erro_sem_ings" runat="server" Height="111px" ImageUrl="~/IMAGENS/erro_sem_ings.png" Visible="False" Width="282px" />
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
        <asp:GridView ID="GridView2" runat="server" CssClass="table-bordered" Visible="False">
        </asp:GridView>
        <br />
        <br />
        <asp:Panel ID="Panel3" Cssclass="card border-primary mb-3" Style="padding: 20px 20px 20px 20px;" runat="server">
            <asp:Label ID="Label14" runat="server" Text="Queres inserir foto? É opcional..."></asp:Label>
            <asp:Image ID="Image2" runat="server" Height="79px" ImageUrl="~/IMAGENS/erro_imagem_extension.png" Visible="False" Width="222px" />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" Height="45px" Width="406px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="Adicionar Imagem" Height="30px" OnClick="Button5_Click" Width="200px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" BorderStyle="Solid" Height="250px" Width="250px" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Preparação:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="200px" Width="869px" TextMode="MultiLine"></asp:TextBox>
            &nbsp;
        <asp:Image ID="erro_prep" runat="server" Height="76px" ImageUrl="~/IMAGENS/erro_nao_falta_nada.png" Width="194px" Visible="False" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" BackColor="#999999" Text="Enviar para Validação!" Width="290px" OnClick="Button2_Click" />
            <asp:Image ID="finalizar" runat="server" Height="97px" ImageUrl="~/IMAGENS/erro_finalizar.png" Width="268px" Visible="False" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Sim !" Width="60px" Visible="False" OnClick="Button3_Click" Height="35px" />
            <asp:Button ID="Button4" runat="server" Text="Não!" Width="60px" Visible="False" OnClick="Button4_Click" Height="35px" />
    
            <br />
            <br />
            <asp:Label ID="Label15" runat="server" ForeColor="#CC0000" Text="Escolhe outro nome para a receita, esse já existe! Que falta de imaginação..." Visible="False"></asp:Label>
    
            <br />
            
    
        </asp:Panel>
<asp:Label ID="Label16" runat="server" Font-Bold="True" ForeColor="#009933" Text="Receita Enviada! :)" Visible="False"></asp:Label>
            &nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Voltar" Visible="False" Height="45px" Width="96px" />
        <br />
        <asp:Label ID="Label17" runat="server" BackColor="White" Font-Bold="True" ForeColor="#CC3300" Text="Algo correu mal e a tua receita foi de vela! " Visible="False"></asp:Label>
    </form>
</asp:Content>

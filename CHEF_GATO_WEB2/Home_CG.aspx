<%@ Page Title="" Language="C#" MasterPageFile="MasterPageCG.Master" AutoEventWireup="true" CodeBehind="Home_CG.aspx.cs" Inherits="CHEF_GATO_WEB2.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form id="form1" runat="server">


    <meta http-equiv="content-type" content="text/html; charset=UTF-8">
    <p>
    </p>

    <style type='text/css'>
        #ctr {
            display: -webkit-flex;
            -webkit-flex-direction: column;
            display: flex;
            flex-direction: column;
        }

        .item {
            width: 400px;
            height: 400px;
            background-color:ActiveBorder;
            margin: 10px;
        }

        @media (min-width: 960px) {
            #ctr {
                display: -webkit-flex;
                -webkit-flex-direction: row;
                display: flex;
                flex-direction: row;
            }
        }
    </style>



    <div id="ctr">
        <div class="item">
            <div class="card text-white bg-secondary mb-3" style="max-width: 22rem; height:250px">
                <div class="card-header"><h3>Delícias de Atum</h3></div>
                <div class="card-body">
                    <h4 class="card-title">A mais votada do mês</h4>
                    <p class="card-text">Esta receita é dedicada a gatos mais velhotes e cheios de caprichos<asp:Button ID="Button1" runat="server" style="position:absolute; bottom:10px; right:15px" Text="Ver" OnClick="Button1_Click" />
                    </p>
                </div>
            </div>
        </div>
        <div class="item">
            <div class="card text-white bg-secondary mb-3" style="max-width: 22rem; height:250px">
                <div class="card-header"><h3>Bolachas de salmão</h3></div>
                <div class="card-body">
                    <h4 class="card-title">Ideal para um pêlo saudável!</h4>
                    <p class="card-text">Para gatos que gostam de estar sempre impecáveis.<asp:Button ID="Button2" runat="server" style="position:absolute; bottom:10px; right:15px" Text="Ver" OnClick="Button2_Click" />
                    </p>
                </div>
            </div>
        </div>
        <div class="item">
            <div class="card text-white bg-secondary mb-3" style="max-width: 22rem; height:250px">
                <div class="card-header"><h3>Bolinhos de atum à C#</h3></div>
                <div class="card-body">
                    <h4 class="card-title">Para gatos muito independentes</h4>
                    <p class="card-text">Com esta receita os gatos dos vizinhos vão aparecer à tua porta...<asp:Button ID="Button3" runat="server" style="position:absolute; bottom:10px; right:15px" Text="Ver" OnClick="Button3_Click" /></p>
                </div>
            </div>
        </div>
    </div>


    </form>
</asp:Content>

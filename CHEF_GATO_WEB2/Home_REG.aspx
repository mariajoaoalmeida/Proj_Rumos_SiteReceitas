<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Registados.Master" AutoEventWireup="true" CodeBehind="Home_REG.aspx.cs" Inherits="CHEF_GATO_WEB2.Default_REG" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

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
            <div class="card text-white bg-secondary mb-3" style="max-width: 20rem;">
                <div class="card-header"><h3>Biscoitos de Atum</h3></div>
                <div class="card-body">
                    <h4 class="card-title">A mais votada do mês</h4>
                    <p class="card-text">Esta receita é dedicada a gatos mais velhotes e cheios de caprichos</p>
                </div>
            </div>
        </div>
        <div class="item">
            <div class="card text-white bg-secondary mb-3" style="max-width: 20rem;">
                <div class="card-header"><h3>Bolinhos de salmão</h3></div>
                <div class="card-body">
                    <h4 class="card-title">Ideal para um pêlo saudável!</h4>
                    <p class="card-text">Para gatos que gostam de estar sempre impecáveis.</p>
                </div>
            </div>
        </div>
        <div class="item">
            <div class="card text-white bg-secondary mb-3" style="max-width: 20rem;">
                <div class="card-header"><h3>Ração à C#</h3></div>
                <div class="card-body">
                    <h4 class="card-title">Para gatos muito independentes</h4>
                    <p class="card-text">Com esta receita os gatos dos vizinhos vão aparecer à tua porta...</p>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

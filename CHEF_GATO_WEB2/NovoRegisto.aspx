<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NovoRegisto.aspx.cs" Inherits="CHEF_GATO_WEB2.NovoRegisto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/bootstrap.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" ContinueDestinationPageUrl="~/Area_Pessoal_REG.aspx" AnswerLabelText="Resposta de seguraça:" AnswerRequiredErrorMessage="Resposta de seguraça é obrigatória!" CompleteSuccessText="Conta criada com sucesso." ConfirmPasswordCompareErrorMessage="A password e a confirmação não correspondem." ConfirmPasswordLabelText="Confirma Password:" ConfirmPasswordRequiredErrorMessage="Confirmação de Password é obrigatória." ContinueButtonText="Continuar" CreateUserButtonText="Criar Conta" DuplicateEmailErrorMessage="O e-mail que colocaste já existe. Tenta com outro." DuplicateUserNameErrorMessage="Escolhe outro Username." EmailRegularExpressionErrorMessage="Por favor, escolhe outro e-mail." EmailRequiredErrorMessage="E-mail é obrigatório." FinishCompleteButtonText="Terminar" FinishPreviousButtonText="Anterior" InvalidAnswerErrorMessage="Introduz outra resposta de segurança." InvalidEmailErrorMessage="Esse email não é válido." InvalidQuestionErrorMessage="Escolhe outra pergunta de segurança." PasswordRegularExpressionErrorMessage="Escolhe outra Password." PasswordRequiredErrorMessage="Password é obrigatória." QuestionLabelText="Pergunta de segurança:" QuestionRequiredErrorMessage="Pergunta de segurança é obrigatória." StartNextButtonText="Próximo" StepNextButtonText="Próximo" StepPreviousButtonText="Anterior" UnknownErrorMessage="A tua conta não foi criada. alguma asneira deves ter feito..." UserNameRequiredErrorMessage="User Name é obrigatório.">
        <WizardSteps>
            <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
            </asp:CompleteWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>
        </div>
    </form>
</body>
</html>

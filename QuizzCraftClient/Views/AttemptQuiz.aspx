<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="AttemptQuiz.aspx.cs" Inherits="QuizzCraftClient.Views.AttemptQuiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" type="text/css" href="Style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <asp:Label ID="QuizSubmit" runat="server" ForeColor="Green"  Text=""></asp:Label>
    
    <asp:GridView ID="GridViewQuestions" runat="server" AutoGenerateColumns="False">
    <Columns>
         <asp:BoundField DataField="QuestionText" HeaderText="Question" />
        <asp:TemplateField HeaderText="Option A">
            <ItemTemplate>
                <asp:RadioButton ID="RadioButtonOptionA" runat="server" Text='<%# Eval("OptionA") %>' GroupName='<%# Eval("QuestionID") %>' />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Option B">
            <ItemTemplate>
                <asp:RadioButton ID="RadioButtonOptionB" runat="server" Text='<%# Eval("OptionB") %>' GroupName='<%# Eval("QuestionID") %>' />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Option C">
            <ItemTemplate>
                <asp:RadioButton ID="RadioButtonOptionC" runat="server" Text='<%# Eval("OptionC") %>' GroupName='<%# Eval("QuestionID") %>' />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Option D">
            <ItemTemplate>
                <asp:RadioButton ID="RadioButtonOptionD" runat="server" Text='<%# Eval("OptionD") %>' GroupName='<%# Eval("QuestionID") %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>


    <asp:Button ID="btnSubmit" runat="server" Text="Submit" Visible="false" CssClass="updateButton"  OnClick="btnSubmitQuiz_Click" />
</asp:Content>

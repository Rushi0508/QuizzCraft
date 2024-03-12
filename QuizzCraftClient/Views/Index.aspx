<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="QuizzCraftClient.Views.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <link rel="stylesheet" type="text/css" href="Style.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>List Of All Quizzes</h1>

    <br>
    <div class="container">
    <div class="row">
        <div class="col-md-9">
                <asp:GridView ID="GridViewQuizzes" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="QuizId" HeaderText="Quiz Id" />
            <asp:BoundField DataField="Title" HeaderText="Quiz Title" />

            <asp:TemplateField HeaderText="Attempt Quiz">
                <ItemTemplate>
                    <asp:Button ID="btnAttemptQuiz" runat="server" Text="Attempt" CssClass="addButton" CommandName="" OnClick="btnAttemptQuiz_Click" CommandArgument='<%# Eval("QuizId") %>' />
                </ItemTemplate>
            </asp:TemplateField>


        </Columns>
    </asp:GridView>
         </div>

        <div class="col">

        </div>
    </div>
</div>



</asp:Content>

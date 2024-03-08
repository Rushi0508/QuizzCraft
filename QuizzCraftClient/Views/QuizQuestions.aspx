<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="QuizQuestions.aspx.cs" Inherits="QuizzCraftClient.Views.QuizQuestions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

      <link rel="stylesheet" type="text/css" href="Style.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>List of Questions </h1>

    <asp:GridView ID="GridViewQuestions" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="QuestionText" HeaderText="Question" />
            <asp:BoundField DataField="OptionA" HeaderText="Option A" />
            <asp:BoundField DataField="OptionB" HeaderText="Option B" />
            <asp:BoundField DataField="OptionC" HeaderText="Option C" />
            <asp:BoundField DataField="OptionD" HeaderText="Option D" />

            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="updateButton"  CommandName="UpdateRow" CommandArgument='<%# Eval("QuestionID") %>' OnClick="btnUpdateQuestion_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="deleteButton" CommandName="DeleteRow" CommandArgument='<%# Eval("QuestionID") %>' OnClick="btnDeleteQuestion_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>

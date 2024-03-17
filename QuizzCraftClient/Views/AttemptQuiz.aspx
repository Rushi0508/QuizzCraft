<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="AttemptQuiz.aspx.cs" Inherits="QuizzCraftClient.Views.AttemptQuiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Style.css" />

    <style>
        /* Style.css */

        .gridview {
            width: 100%;
            border-collapse: collapse;
            border-spacing: 0;
            margin-bottom: 20px;
        }

            .gridview th,
            .gridview td {
                padding: 8px;
                text-align: left;
                border-bottom: 1px solid #ddd;
            }

            .gridview th {
                background-color: #f2f2f2;
            }

        .btn {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 8px 16px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 14px;
            border-radius: 4px;
            cursor: pointer;
            margin-right: 4px;
        }

            .btn:hover {
                background-color: #0056b3;
            }

        .submitButton {
            background-color: #28a745;
        }

        .updateButton {
            background-color: #007bff;
        }

        .deleteButton {
            background-color: #dc3545;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="QuizSubmit" runat="server" ForeColor="Green" Text=""></asp:Label>

    <div class="container">
        <h1>Questions </h1>
        <asp:GridView ID="GridViewQuestions" runat="server" AutoGenerateColumns="False" CssClass="gridview">
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

       <asp:Button ID="btnSubmit" runat="server" Text="Submit" Visible="false" class="btn btn-success" OnClick="btnSubmitQuiz_Click" />
    </div>
</asp:Content>

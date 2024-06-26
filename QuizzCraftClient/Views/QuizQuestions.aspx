﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="QuizQuestions.aspx.cs" Inherits="QuizzCraftClient.Views.QuizQuestions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="Style.css" />
    <style>
        /* Style.css */

        .gridview {
            width: 100%;
            border-collapse: collapse;
            border-spacing: 0;
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
            padding: 6px 12px;
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

        .updateButton {
            background-color: #28a745;
        }

        .deleteButton {
            background-color: #dc3545;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="row my-3">

            <div class="col-4">
                <asp:Label ID="label" class="fs-3" runat="server" Text="Name : "></asp:Label>
                <asp:Label ID="qtitle" class="fs-4 text-white bg-primary" runat="server"></asp:Label>
            </div>
            <div class="col-4">
                <asp:Label ID="pagetitle" runat="server" class="fs-2" Text="List of Questions"></asp:Label>
            </div>
            <div class="col-4">
                <asp:Label ID="subjectlabel" class="fs-3" runat="server" Text="Subject : "></asp:Label>
                <asp:Label ID="qsubject" class="fs-4 text-white bg-success" runat="server"></asp:Label>
            </div>
        </div>

        <asp:GridView ID="GridViewQuestions" runat="server" AutoGenerateColumns="False" CssClass="gridview">
            <Columns>
                <asp:BoundField DataField="QuestionText" HeaderText="Question" />
                <asp:BoundField DataField="OptionA" HeaderText="Option A" />
                <asp:BoundField DataField="OptionB" HeaderText="Option B" />
                <asp:BoundField DataField="OptionC" HeaderText="Option C" />
                <asp:BoundField DataField="OptionD" HeaderText="Option D" />
                <asp:BoundField DataField="CorrectAnswer" HeaderText="Correct Answer : Option" />
                <asp:TemplateField HeaderText="Update Question">
                    <ItemTemplate>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn updateButton" CommandName="UpdateRow" CommandArgument='<%# Eval("QuestionID") %>' OnClick="btnUpdateQuestion_Click" />

                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete Question">
                    <ItemTemplate>

                        <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn deleteButton" CommandName="DeleteRow" CommandArgument='<%# Eval("QuestionID") %>' OnClick="btnDeleteQuestion_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

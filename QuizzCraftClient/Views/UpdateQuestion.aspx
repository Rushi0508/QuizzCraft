<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="UpdateQuestion.aspx.cs" Inherits="QuizzCraftClient.Views.UpdateQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Style.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-2">
    <div class="row justify-content-center">
        <div class="col-md-6">
            <div class="card">
                <div class="card-body">

                    <center>
                        <h2>Update Question</h2>

                        <asp:Label ID="lblUpdateSuccessfull" runat="server" ForeColor="Green"></asp:Label>

                    </center>

                    <hr>

                    <div class="mb-3">
                        <label for="txtQuestion">Question Text:</label>
                        <asp:RequiredFieldValidator ID="rfvQuestion" runat="server" ControlToValidate="txtQuestion" ErrorMessage="Question text is required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:TextBox CssClass="form-control" ID="txtQuestion" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox>

                    </div>

                    <div class="mb-3">
                        <label for="txtOptionA">Option A:</label>
                        <asp:RequiredFieldValidator ID="rfvOptionA" runat="server" ControlToValidate="txtOptionA" ErrorMessage="Option A is required" ForeColor="Red"></asp:RequiredFieldValidator>

                        <asp:TextBox CssClass="form-control" ID="txtOptionA" runat="server"></asp:TextBox><br />
                    </div>

                    <div class="mb-3">
                        <label for="txtOptionB">Option B:</label>
                        <asp:RequiredFieldValidator ID="rfvOptionB" runat="server" ControlToValidate="txtOptionB" ErrorMessage="Option B is required" ForeColor="Red"></asp:RequiredFieldValidator>

                        <asp:TextBox CssClass="form-control" ID="txtOptionB" runat="server"></asp:TextBox><br />
                    </div>

                    <div class="mb-3">
                        <label for="txtOptionC">Option C:</label>
                        <asp:RequiredFieldValidator ID="rfvOptionC" runat="server" ControlToValidate="txtOptionC" ErrorMessage="Option C is required" ForeColor="Red"></asp:RequiredFieldValidator>

                        <asp:TextBox CssClass="form-control" ID="txtOptionC" runat="server"></asp:TextBox><br />
                    </div>

                    <div class="mb-3">
                        <label for="txtOptionD">Option D:</label>
                        <asp:RequiredFieldValidator ID="rfvOptionD" runat="server" ControlToValidate="txtOptionD" ErrorMessage="Option D is required" ForeColor="Red"></asp:RequiredFieldValidator>

                        <asp:TextBox CssClass="form-control" ID="txtOptionD" runat="server"></asp:TextBox><br />
                    </div>



                    <div>
                        <label for="CorrectAnswer">Correct Answer:</label>
                        <asp:DropDownList ID="CorrectAnswer" runat="server">
                            <asp:ListItem Text="A" Value="A"></asp:ListItem>
                            <asp:ListItem Text="B" Value="B"></asp:ListItem>
                            <asp:ListItem Text="C" Value="C"></asp:ListItem>
                            <asp:ListItem Text="D" Value="D"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <br />





                    <div class="d-grid gap-2">


                        
           <asp:Button ID="btnUpdate" class="btn btn-warning btn-block" runat="server" Text="Update"   OnClick="btnUpdateQuestion_Click" />


                    </div>


                </div>
            </div>

        </div>
    </div>
</div>



</asp:Content>

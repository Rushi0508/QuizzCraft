<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="TeacherSignUp.aspx.cs" Inherits="QuizzCraftClient.Views.TeacherSignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-5">
        <div class="row justify-content-center">

            <div class="col-md-6">
                <img width="700px" src="/images/t.png" />
            </div>
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                </center>
                            </div>
                        </div>

                        <h3 class="text-center">Teacher SignUp</h3>
                        <center>

                            <asp:Label ID="lblSignUpSuccessfull" runat="server" ForeColor="Green"></asp:Label>
                            <asp:Label ID="lblSignUpError" runat="server" ForeColor="Red"></asp:Label>
                        </center>

                        <hr>

                        <div class="mb-3">
                            <label for="name" class="form-label">Name&nbsp;&nbsp;&nbsp; </label>
                            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="tbName" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            &nbsp;<asp:TextBox CssClass="form-control" ID="tbName" runat="server" placeholder="Name"></asp:TextBox>
                        </div>

                        <div class="mb-3">
                            <label for="emailID" class="form-label">
                                Email ID
                            &nbsp;
                            </label>
                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="Email is required" ForeColor="Red"></asp:RequiredFieldValidator>

                            <asp:TextBox CssClass="form-control" ID="tbEmail" runat="server" placeholder="Email ID" TextMode="Email"></asp:TextBox>
                        </div>




                        <div class="mb-3">
                            <label for="password" class="form-label">Password&nbsp;&nbsp; </label>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="tbPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            &nbsp;<asp:TextBox CssClass="form-control" ID="tbPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>

                        <div class="mb-3">
                            <label for="cpassword" class="form-label">Confirm Password</label>
                            &nbsp;<asp:TextBox CssClass="form-control" ID="tbConfirmPassword" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                            <asp:Label ID="lblConfirmPassword" runat="server" ForeColor="Red"></asp:Label>
                        </div>


                        <br>

                        <div class="d-grid gap-2">
                            <asp:Button class="btn btn-success btn-block" ID="btnSignUp" runat="server" Text="SignUp" OnClick="btnSignUp_Click" />
                            <a href="TeacherSignIn.aspx" class="btn btn-info btn-block">SignIn</a>
                        </div>

                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>

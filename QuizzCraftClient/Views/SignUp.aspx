<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="QuizzCraftClient.Views.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container mt-5">
     <div class="row justify-content-center">
         <div class="col-md-6">
             <div class="card">
                 <div class="card-body">

                     <div class="row">
                         <div class="col">
                             <center>
                                 <img width="200px" src="/images/signup.png" />
                             </center>
                         </div>
                     </div>

                     <h3 class="text-center">SignUp</h3>
                     <hr>
                     <div class="row">
                         <div class="col-6">
                             <div class="d-grid gap-2">
                                  <center>
                             <img src="/images/teacher.png" width="150">
                                       </center>
                                 <a href="TeacherSignUp.aspx" class="btn btn-info btn-block">Teacher SignUp</a>
                             </div>
                         </div>
                         <div class="col-6">
                             <div class="d-grid gap-2">
                                  <center>
                                 <img src="/images/student.png" width="150">
                                  </center>
                                 <a href="UserSignUp.aspx" class="btn btn-info btn-block">Student SignUp</a>
                             </div>
                         </div>
                     </div>

                     
                     <hr>
                     <br>
                 </div>
             </div>

         </div>
     </div>
 </div>

</asp:Content>

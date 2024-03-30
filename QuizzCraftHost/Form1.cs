using QuizzCraftService.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzCraftHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceHost userSh;
        ServiceHost teacherSh;
        ServiceHost quizSh;
        ServiceHost questionSh;

        private void Form1_Load(object sender, EventArgs e)
        {
            Uri usera = new Uri("net.tcp://localhost:8000/UserService");
            Uri teachera = new Uri("net.tcp://localhost:8000/TeacherService");
            Uri quiza = new Uri("net.tcp://localhost:8000/QuizService");
            Uri questiona = new Uri("net.tcp://localhost:8000/QuestionService");

            try
            {
                userSh = new ServiceHost(typeof(UserService), usera);
                teacherSh = new ServiceHost(typeof(TeacherService), teachera);
                quizSh = new ServiceHost(typeof(QuizService), quiza);
                questionSh = new ServiceHost(typeof(QuestionService), questiona);


                NetTcpBinding userb = new NetTcpBinding();
                NetTcpBinding teacherb = new NetTcpBinding();
                NetTcpBinding quizb = new NetTcpBinding();
                NetTcpBinding questionb = new NetTcpBinding();


                ServiceMetadataBehavior userMBehave = new ServiceMetadataBehavior();
                ServiceMetadataBehavior teacherMBehave = new ServiceMetadataBehavior();
                ServiceMetadataBehavior quizMBehave = new ServiceMetadataBehavior();
                ServiceMetadataBehavior questionMBehave = new ServiceMetadataBehavior();


                userSh.Description.Behaviors.Add(userMBehave);
                teacherSh.Description.Behaviors.Add(teacherMBehave);
                quizSh.Description.Behaviors.Add(quizMBehave);
                questionSh.Description.Behaviors.Add(questionMBehave);


                userSh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");
                teacherSh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");
                quizSh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");
                questionSh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");


                userSh.AddServiceEndpoint(typeof(IUserService), userb, usera);
                teacherSh.AddServiceEndpoint(typeof(ITeacherService), teacherb, teachera);
                quizSh.AddServiceEndpoint(typeof(IQuizService), quizb, quiza);
                questionSh.AddServiceEndpoint(typeof(IQuestionService), questionb, questiona);


                userSh.Open();
                teacherSh.Open();
                quizSh.Open();
                questionSh.Open();

                label1.Text = "Host is Running.....";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

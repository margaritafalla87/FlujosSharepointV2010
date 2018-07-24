using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.WorkflowActions;

namespace FlujoosSHP2010.FlujosdeTrabajo.WFRegimenCambiario
{
      public sealed partial class WFRegimenCambiario : StateMachineWorkflowActivity
      {
            public WFRegimenCambiario()
            {
                  InitializeComponent();
            }

            public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();
            public Int32 IdTareas = default(System.Int32);
            public Guid TaskId1 = default(System.Guid);
            public SPWorkflowTaskProperties TaskProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

            private void create_task_Invoking(object sender, EventArgs e)
            {
                  TaskId1 = Guid.NewGuid();
                  TaskProperties1.Title = "Revisar Operacion";
                  TaskProperties1.AssignedTo = @"i:0#.w|local\funcionario1";
                  TaskProperties1.DueDate = DateTime.Now.AddDays(1);

            }

            public SPWorkflowTaskProperties onTaskChanged1_AfterProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
            public SPWorkflowTaskProperties onTaskChanged1_BeforeProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

            private void onTaskChanged1_Invoked(object sender, ExternalDataEventArgs e)
            {
                  onTaskChanged1_AfterProperties1 = onTaskChanged1.AfterProperties;
                  onTaskChanged1_BeforeProperties1 = onTaskChanged1.BeforeProperties;
            }

            private void ReadyForReview(object sender, ConditionalEventArgs e)
            {
                  if (onTaskChanged1_AfterProperties1.PercentComplete == 1.0)
                  {
                        e.Result = true;
                  }
                  else
                  {
                        e.Result = false;
                  }
            }

            public Guid createTask2_TaskId1 = default(System.Guid);
            public SPWorkflowTaskProperties createTask2_TaskProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

            private void createTask2_MethodInvoking(object sender, EventArgs e)
            {
                  createTask2_TaskId1 = Guid.NewGuid();
                  createTask2_TaskProperties1.Title = "Aprobar Operación";
                  createTask2_TaskProperties1.AssignedTo = @"i:0#.w|local\coodinador1";
                  createTask2_TaskProperties1.DueDate = DateTime.Now.AddDays(1);

            }

            public SPWorkflowTaskProperties onTaskChanged2_AfterProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
            public SPWorkflowTaskProperties onTaskChanged2_BeforeProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

            private void onTaskChanged2_Invoked(object sender, ExternalDataEventArgs e)
            {
                  onTaskChanged2_AfterProperties1 = onTaskChanged2.AfterProperties;
                  onTaskChanged2_BeforeProperties1 = onTaskChanged2.BeforeProperties;
            }
            private void ReviewFinished(object sender, ConditionalEventArgs e)
            {
                  if (onTaskChanged2_AfterProperties1.PercentComplete == 1.0)
                  {
                        e.Result = true;
                  }
                  else
                  {
                        e.Result = false;
                  }
            }

            private void DocApproved(object sender, ConditionalEventArgs e)
            {
                  if (onTaskChanged2_AfterProperties1.PercentComplete == 1.0)
                  {
                        e.Result = true;
                  }
                  else
                  {
                        e.Result = false;
                  }
            }

            public Guid createTask_CrearExp_TaskId = default(System.Guid);
            public SPWorkflowTaskProperties createTask_CrearExp_TaskProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
            private void create_task_CrearEpx_Invoking(object sender, EventArgs e)
            {
                  createTask_CrearExp_TaskId = Guid.NewGuid();
                  createTask_CrearExp_TaskProperties1.Title = "Crear Expediente";
                  createTask_CrearExp_TaskProperties1.AssignedTo = @"i:0#.w|local\funcionario1";
                  createTask_CrearExp_TaskProperties1.DueDate = DateTime.Now.AddDays(1);

            }

            public SPWorkflowTaskProperties onTaskChanged_CrearExp_AfterProperties2 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
            public SPWorkflowTaskProperties onTaskChanged_CrearExp_BeforeProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
            public Guid onTaskChanged_CrearExp_TaskId1 = default(System.Guid);

            private void onTaskChanged_CrearExp_Invoked(object sender, ExternalDataEventArgs e)
            {
                  onTaskChanged_CrearExp_AfterProperties2 = onTaskChanged3.AfterProperties;
                  onTaskChanged2_BeforeProperties1 = onTaskChanged3.BeforeProperties;
            }
            private void ExpedienteCreado(object sender, ConditionalEventArgs e)
            {
                  if (onTaskChanged_CrearExp_AfterProperties2.PercentComplete == 1.0)
                  {
                        e.Result = true;
                  }
                  else
                  {
                        e.Result = false;
                  }
            }


      }
}

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace FlujoosSHP2010.FlujosdeTrabajo.WFRegimenCambiario
{
      public sealed partial class WFRegimenCambiario
      {
            #region Designer generated code

            /// <summary> 
            /// Método necesario para admitir el Diseñador. No se puede modificar
            /// el contenido del método con el editor de código.
            /// </summary>
            [System.Diagnostics.DebuggerNonUserCode]
            private void InitializeComponent()
            {
                  this.CanModifyActivities = true;
                  System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
                  System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
                  System.Workflow.Activities.CodeCondition codecondition3 = new System.Workflow.Activities.CodeCondition();
                  System.Workflow.Activities.CodeCondition codecondition4 = new System.Workflow.Activities.CodeCondition();
                  System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
                  System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.Runtime.CorrelationToken correlationtoken2 = new System.Workflow.Runtime.CorrelationToken();
                  System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind10 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind11 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind12 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.Runtime.CorrelationToken correlationtoken3 = new System.Workflow.Runtime.CorrelationToken();
                  System.Workflow.ComponentModel.ActivityBind activitybind13 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind14 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.ComponentModel.ActivityBind activitybind15 = new System.Workflow.ComponentModel.ActivityBind();
                  System.Workflow.Runtime.CorrelationToken correlationtoken4 = new System.Workflow.Runtime.CorrelationToken();
                  System.Workflow.ComponentModel.ActivityBind activitybind16 = new System.Workflow.ComponentModel.ActivityBind();
                  this.setStateActivity4 = new System.Workflow.Activities.SetStateActivity();
                  this.setStateActivity3 = new System.Workflow.Activities.SetStateActivity();
                  this.ifElseBranchActivity6 = new System.Workflow.Activities.IfElseBranchActivity();
                  this.ifElseBranchActivity5 = new System.Workflow.Activities.IfElseBranchActivity();
                  this.setStateActivity5 = new System.Workflow.Activities.SetStateActivity();
                  this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
                  this.ifElseActivity3 = new System.Workflow.Activities.IfElseActivity();
                  this.ifElseBranchActivity8 = new System.Workflow.Activities.IfElseBranchActivity();
                  this.ifElseBranchActivity7 = new System.Workflow.Activities.IfElseBranchActivity();
                  this.ifElseBranchActivity2 = new System.Workflow.Activities.IfElseBranchActivity();
                  this.ifElseBranchActivity1 = new System.Workflow.Activities.IfElseBranchActivity();
                  this.ifElseBranchActivity4 = new System.Workflow.Activities.IfElseBranchActivity();
                  this.ifElseBranchActivity3 = new System.Workflow.Activities.IfElseBranchActivity();
                  this.ifElseActivity4 = new System.Workflow.Activities.IfElseActivity();
                  this.onTaskChanged3 = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
                  this.createTask_CrearExp = new Microsoft.SharePoint.WorkflowActions.CreateTask();
                  this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
                  this.onTaskChanged1 = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
                  this.createTask1 = new Microsoft.SharePoint.WorkflowActions.CreateTask();
                  this.ifElseActivity2 = new System.Workflow.Activities.IfElseActivity();
                  this.onTaskChanged2 = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
                  this.createTask2 = new Microsoft.SharePoint.WorkflowActions.CreateTask();
                  this.setStateActivity1 = new System.Workflow.Activities.SetStateActivity();
                  this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
                  this.eventDrivenActivity4 = new System.Workflow.Activities.EventDrivenActivity();
                  this.stateInitializationActivity3 = new System.Workflow.Activities.StateInitializationActivity();
                  this.eventDrivenActivity2 = new System.Workflow.Activities.EventDrivenActivity();
                  this.stateInitializationActivity1 = new System.Workflow.Activities.StateInitializationActivity();
                  this.eventDrivenActivity3 = new System.Workflow.Activities.EventDrivenActivity();
                  this.stateInitializationActivity2 = new System.Workflow.Activities.StateInitializationActivity();
                  this.eventDrivenActivity1 = new System.Workflow.Activities.EventDrivenActivity();
                  this.stateCrearExpediente = new System.Workflow.Activities.StateActivity();
                  this.stateFinished = new System.Workflow.Activities.StateActivity();
                  this.stateInProgress = new System.Workflow.Activities.StateActivity();
                  this.stateReview = new System.Workflow.Activities.StateActivity();
                  this.WFRegimenCambiarioInitialState = new System.Workflow.Activities.StateActivity();
                  // 
                  // setStateActivity4
                  // 
                  this.setStateActivity4.Name = "setStateActivity4";
                  this.setStateActivity4.TargetStateName = "stateInProgress";
                  // 
                  // setStateActivity3
                  // 
                  this.setStateActivity3.Name = "setStateActivity3";
                  this.setStateActivity3.TargetStateName = "stateCrearExpediente";
                  // 
                  // ifElseBranchActivity6
                  // 
                  this.ifElseBranchActivity6.Activities.Add(this.setStateActivity4);
                  this.ifElseBranchActivity6.Name = "ifElseBranchActivity6";
                  // 
                  // ifElseBranchActivity5
                  // 
                  this.ifElseBranchActivity5.Activities.Add(this.setStateActivity3);
                  codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.DocApproved);
                  this.ifElseBranchActivity5.Condition = codecondition1;
                  this.ifElseBranchActivity5.Name = "ifElseBranchActivity5";
                  // 
                  // setStateActivity5
                  // 
                  this.setStateActivity5.Name = "setStateActivity5";
                  this.setStateActivity5.TargetStateName = "stateFinished";
                  // 
                  // setStateActivity2
                  // 
                  this.setStateActivity2.Name = "setStateActivity2";
                  this.setStateActivity2.TargetStateName = "stateReview";
                  // 
                  // ifElseActivity3
                  // 
                  this.ifElseActivity3.Activities.Add(this.ifElseBranchActivity5);
                  this.ifElseActivity3.Activities.Add(this.ifElseBranchActivity6);
                  this.ifElseActivity3.Name = "ifElseActivity3";
                  // 
                  // ifElseBranchActivity8
                  // 
                  this.ifElseBranchActivity8.Name = "ifElseBranchActivity8";
                  // 
                  // ifElseBranchActivity7
                  // 
                  this.ifElseBranchActivity7.Activities.Add(this.setStateActivity5);
                  codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ExpedienteCreado);
                  this.ifElseBranchActivity7.Condition = codecondition2;
                  this.ifElseBranchActivity7.Name = "ifElseBranchActivity7";
                  // 
                  // ifElseBranchActivity2
                  // 
                  this.ifElseBranchActivity2.Name = "ifElseBranchActivity2";
                  // 
                  // ifElseBranchActivity1
                  // 
                  this.ifElseBranchActivity1.Activities.Add(this.setStateActivity2);
                  codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ReadyForReview);
                  this.ifElseBranchActivity1.Condition = codecondition3;
                  this.ifElseBranchActivity1.Name = "ifElseBranchActivity1";
                  // 
                  // ifElseBranchActivity4
                  // 
                  this.ifElseBranchActivity4.Name = "ifElseBranchActivity4";
                  // 
                  // ifElseBranchActivity3
                  // 
                  this.ifElseBranchActivity3.Activities.Add(this.ifElseActivity3);
                  codecondition4.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ReviewFinished);
                  this.ifElseBranchActivity3.Condition = codecondition4;
                  this.ifElseBranchActivity3.Name = "ifElseBranchActivity3";
                  // 
                  // ifElseActivity4
                  // 
                  this.ifElseActivity4.Activities.Add(this.ifElseBranchActivity7);
                  this.ifElseActivity4.Activities.Add(this.ifElseBranchActivity8);
                  this.ifElseActivity4.Name = "ifElseActivity4";
                  // 
                  // onTaskChanged3
                  // 
                  activitybind1.Name = "WFRegimenCambiario";
                  activitybind1.Path = "onTaskChanged_CrearExp_AfterProperties2";
                  activitybind2.Name = "WFRegimenCambiario";
                  activitybind2.Path = "onTaskChanged_CrearExp_BeforeProperties1";
                  correlationtoken1.Name = "CrearStateToken";
                  correlationtoken1.OwnerActivityName = "stateCrearExpediente";
                  this.onTaskChanged3.CorrelationToken = correlationtoken1;
                  this.onTaskChanged3.Executor = null;
                  this.onTaskChanged3.Name = "onTaskChanged3";
                  activitybind3.Name = "WFRegimenCambiario";
                  activitybind3.Path = "onTaskChanged_CrearExp_TaskId1";
                  this.onTaskChanged3.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onTaskChanged_CrearExp_Invoked);
                  this.onTaskChanged3.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
                  this.onTaskChanged3.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
                  this.onTaskChanged3.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
                  // 
                  // createTask_CrearExp
                  // 
                  this.createTask_CrearExp.CorrelationToken = correlationtoken1;
                  this.createTask_CrearExp.ListItemId = -1;
                  this.createTask_CrearExp.Name = "createTask_CrearExp";
                  this.createTask_CrearExp.SpecialPermissions = null;
                  activitybind4.Name = "WFRegimenCambiario";
                  activitybind4.Path = "createTask_CrearExp_TaskId";
                  activitybind5.Name = "WFRegimenCambiario";
                  activitybind5.Path = "createTask_CrearExp_TaskProperties1";
                  this.createTask_CrearExp.MethodInvoking += new System.EventHandler(this.create_task_CrearEpx_Invoking);
                  this.createTask_CrearExp.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
                  this.createTask_CrearExp.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
                  // 
                  // ifElseActivity1
                  // 
                  this.ifElseActivity1.Activities.Add(this.ifElseBranchActivity1);
                  this.ifElseActivity1.Activities.Add(this.ifElseBranchActivity2);
                  this.ifElseActivity1.Name = "ifElseActivity1";
                  // 
                  // onTaskChanged1
                  // 
                  activitybind6.Name = "WFRegimenCambiario";
                  activitybind6.Path = "onTaskChanged1_AfterProperties1";
                  activitybind7.Name = "WFRegimenCambiario";
                  activitybind7.Path = "onTaskChanged1_BeforeProperties1";
                  correlationtoken2.Name = "InprogessToken";
                  correlationtoken2.OwnerActivityName = "stateInProgress";
                  this.onTaskChanged1.CorrelationToken = correlationtoken2;
                  this.onTaskChanged1.Executor = null;
                  this.onTaskChanged1.Name = "onTaskChanged1";
                  activitybind8.Name = "WFRegimenCambiario";
                  activitybind8.Path = "TaskId1";
                  this.onTaskChanged1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onTaskChanged1_Invoked);
                  this.onTaskChanged1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
                  this.onTaskChanged1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
                  this.onTaskChanged1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
                  // 
                  // createTask1
                  // 
                  this.createTask1.CorrelationToken = correlationtoken2;
                  this.createTask1.ListItemId = -1;
                  this.createTask1.Name = "createTask1";
                  this.createTask1.SpecialPermissions = null;
                  activitybind9.Name = "WFRegimenCambiario";
                  activitybind9.Path = "TaskId1";
                  activitybind10.Name = "WFRegimenCambiario";
                  activitybind10.Path = "TaskProperties1";
                  this.createTask1.MethodInvoking += new System.EventHandler(this.create_task_Invoking);
                  this.createTask1.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind10)));
                  this.createTask1.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
                  // 
                  // ifElseActivity2
                  // 
                  this.ifElseActivity2.Activities.Add(this.ifElseBranchActivity3);
                  this.ifElseActivity2.Activities.Add(this.ifElseBranchActivity4);
                  this.ifElseActivity2.Name = "ifElseActivity2";
                  // 
                  // onTaskChanged2
                  // 
                  activitybind11.Name = "WFRegimenCambiario";
                  activitybind11.Path = "onTaskChanged2_AfterProperties1";
                  activitybind12.Name = "WFRegimenCambiario";
                  activitybind12.Path = "onTaskChanged2_BeforeProperties1";
                  correlationtoken3.Name = "ReviewStateToken";
                  correlationtoken3.OwnerActivityName = "stateReview";
                  this.onTaskChanged2.CorrelationToken = correlationtoken3;
                  this.onTaskChanged2.Executor = null;
                  this.onTaskChanged2.Name = "onTaskChanged2";
                  activitybind13.Name = "WFRegimenCambiario";
                  activitybind13.Path = "createTask2_TaskId1";
                  this.onTaskChanged2.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onTaskChanged2_Invoked);
                  this.onTaskChanged2.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind13)));
                  this.onTaskChanged2.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind11)));
                  this.onTaskChanged2.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind12)));
                  // 
                  // createTask2
                  // 
                  this.createTask2.CorrelationToken = correlationtoken3;
                  this.createTask2.ListItemId = -1;
                  this.createTask2.Name = "createTask2";
                  this.createTask2.SpecialPermissions = null;
                  activitybind14.Name = "WFRegimenCambiario";
                  activitybind14.Path = "createTask2_TaskId1";
                  activitybind15.Name = "WFRegimenCambiario";
                  activitybind15.Path = "createTask2_TaskProperties1";
                  this.createTask2.MethodInvoking += new System.EventHandler(this.createTask2_MethodInvoking);
                  this.createTask2.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind14)));
                  this.createTask2.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind15)));
                  // 
                  // setStateActivity1
                  // 
                  this.setStateActivity1.Name = "setStateActivity1";
                  this.setStateActivity1.TargetStateName = "stateInProgress";
                  // 
                  // onWorkflowActivated1
                  // 
                  correlationtoken4.Name = "InitialToken";
                  correlationtoken4.OwnerActivityName = "WFRegimenCambiarioInitialState";
                  this.onWorkflowActivated1.CorrelationToken = correlationtoken4;
                  this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
                  this.onWorkflowActivated1.Name = "onWorkflowActivated1";
                  activitybind16.Name = "WFRegimenCambiario";
                  activitybind16.Path = "workflowProperties";
                  this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind16)));
                  // 
                  // eventDrivenActivity4
                  // 
                  this.eventDrivenActivity4.Activities.Add(this.onTaskChanged3);
                  this.eventDrivenActivity4.Activities.Add(this.ifElseActivity4);
                  this.eventDrivenActivity4.Name = "eventDrivenActivity4";
                  // 
                  // stateInitializationActivity3
                  // 
                  this.stateInitializationActivity3.Activities.Add(this.createTask_CrearExp);
                  this.stateInitializationActivity3.Name = "stateInitializationActivity3";
                  // 
                  // eventDrivenActivity2
                  // 
                  this.eventDrivenActivity2.Activities.Add(this.onTaskChanged1);
                  this.eventDrivenActivity2.Activities.Add(this.ifElseActivity1);
                  this.eventDrivenActivity2.Name = "eventDrivenActivity2";
                  // 
                  // stateInitializationActivity1
                  // 
                  this.stateInitializationActivity1.Activities.Add(this.createTask1);
                  this.stateInitializationActivity1.Name = "stateInitializationActivity1";
                  // 
                  // eventDrivenActivity3
                  // 
                  this.eventDrivenActivity3.Activities.Add(this.onTaskChanged2);
                  this.eventDrivenActivity3.Activities.Add(this.ifElseActivity2);
                  this.eventDrivenActivity3.Name = "eventDrivenActivity3";
                  // 
                  // stateInitializationActivity2
                  // 
                  this.stateInitializationActivity2.Activities.Add(this.createTask2);
                  this.stateInitializationActivity2.Name = "stateInitializationActivity2";
                  // 
                  // eventDrivenActivity1
                  // 
                  this.eventDrivenActivity1.Activities.Add(this.onWorkflowActivated1);
                  this.eventDrivenActivity1.Activities.Add(this.setStateActivity1);
                  this.eventDrivenActivity1.Name = "eventDrivenActivity1";
                  // 
                  // stateCrearExpediente
                  // 
                  this.stateCrearExpediente.Activities.Add(this.stateInitializationActivity3);
                  this.stateCrearExpediente.Activities.Add(this.eventDrivenActivity4);
                  this.stateCrearExpediente.Name = "stateCrearExpediente";
                  // 
                  // stateFinished
                  // 
                  this.stateFinished.Name = "stateFinished";
                  // 
                  // stateInProgress
                  // 
                  this.stateInProgress.Activities.Add(this.stateInitializationActivity1);
                  this.stateInProgress.Activities.Add(this.eventDrivenActivity2);
                  this.stateInProgress.Name = "stateInProgress";
                  // 
                  // stateReview
                  // 
                  this.stateReview.Activities.Add(this.stateInitializationActivity2);
                  this.stateReview.Activities.Add(this.eventDrivenActivity3);
                  this.stateReview.Name = "stateReview";
                  // 
                  // WFRegimenCambiarioInitialState
                  // 
                  this.WFRegimenCambiarioInitialState.Activities.Add(this.eventDrivenActivity1);
                  this.WFRegimenCambiarioInitialState.Name = "WFRegimenCambiarioInitialState";
                  // 
                  // WFRegimenCambiario
                  // 
                  this.Activities.Add(this.WFRegimenCambiarioInitialState);
                  this.Activities.Add(this.stateReview);
                  this.Activities.Add(this.stateInProgress);
                  this.Activities.Add(this.stateFinished);
                  this.Activities.Add(this.stateCrearExpediente);
                  this.CompletedStateName = "stateFinished";
                  this.DynamicUpdateCondition = null;
                  this.InitialStateName = "WFRegimenCambiarioInitialState";
                  this.Name = "WFRegimenCambiario";
                  this.CanModifyActivities = false;

            }

            #endregion

            private Microsoft.SharePoint.WorkflowActions.CreateTask createTask_CrearExp;

            private StateInitializationActivity stateInitializationActivity3;

            private StateActivity stateCrearExpediente;

            private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onTaskChanged3;

            private EventDrivenActivity eventDrivenActivity4;

            private SetStateActivity setStateActivity5;

            private IfElseBranchActivity ifElseBranchActivity8;

            private IfElseBranchActivity ifElseBranchActivity7;

            private IfElseActivity ifElseActivity4;

            private SetStateActivity setStateActivity4;

            private SetStateActivity setStateActivity3;

            private IfElseBranchActivity ifElseBranchActivity6;

            private IfElseBranchActivity ifElseBranchActivity5;

            private IfElseActivity ifElseActivity3;

            private IfElseBranchActivity ifElseBranchActivity4;

            private IfElseBranchActivity ifElseBranchActivity3;

            private IfElseActivity ifElseActivity2;

            private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onTaskChanged2;

            private EventDrivenActivity eventDrivenActivity3;

            private SetStateActivity setStateActivity2;

            private Microsoft.SharePoint.WorkflowActions.CreateTask createTask2;

            private StateInitializationActivity stateInitializationActivity2;

            private IfElseBranchActivity ifElseBranchActivity2;

            private IfElseBranchActivity ifElseBranchActivity1;

            private IfElseActivity ifElseActivity1;

            private EventDrivenActivity eventDrivenActivity2;

            private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onTaskChanged1;

            private SetStateActivity setStateActivity1;

            private StateActivity stateFinished;

            private StateActivity stateInProgress;

            private StateActivity stateReview;

            private Microsoft.SharePoint.WorkflowActions.CreateTask createTask1;

            private StateInitializationActivity stateInitializationActivity1;

            private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;

            private EventDrivenActivity eventDrivenActivity1;

            private StateActivity WFRegimenCambiarioInitialState;



































































      }
}

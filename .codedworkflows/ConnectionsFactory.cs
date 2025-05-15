using UiPath.CodedWorkflows;
using System;

namespace PRP031Step4_SAP_CargaSpedxEasyWay_Performer
{
    public class ExcelFactory
    {
        public ExcelFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class O365MailFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection GrupoCCR_rpa_indice_motiva_com_br { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection GrupoCCR_gbs_squadrpa_motiva_com_br { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection GrupoCCR_rpa_contasreceber_motiva_com_br { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection GrupoCCR_rpa_contasreceber_motiva_com_br__2 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Contas_a_Receber_rpa_contasreceber_motiva_com_br__3 { get; set; }

        public O365MailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            GrupoCCR_rpa_indice_motiva_com_br = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("307df1c6-4dce-45d5-a328-7aa5fe20d0c9", resolver);
            GrupoCCR_gbs_squadrpa_motiva_com_br = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("a8c765d5-1aec-409a-8c3b-d01521f1f08c", resolver);
            GrupoCCR_rpa_contasreceber_motiva_com_br = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("fd403ab3-5a20-45ed-a079-fe2d816c94a3", resolver);
            GrupoCCR_rpa_contasreceber_motiva_com_br__2 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("0fc8705e-a92d-4fe0-9de1-08e5ed35792c", resolver);
            Contas_a_Receber_rpa_contasreceber_motiva_com_br__3 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("bb0f8368-5f1e-4850-8284-abb7c1eebadd", resolver);
        }
    }

    public class OneDriveFactory
    {
        public OneDriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }
}
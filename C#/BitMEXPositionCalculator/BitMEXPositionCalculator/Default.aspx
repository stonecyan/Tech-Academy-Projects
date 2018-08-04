﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BitMEXPositionCalculator._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <div class="row no-gutters">
            <div class="card col-sm-12 col-md-10 col-lg-5 mx-auto">
                <div class="card-header">
                    <h4 class="text-center">BitMEX Position Size Calculator</h4>
                    </div>
                </div>
            </div>
                       
                    <div class="card-body text-center">
                        <div>
                            <p class="font-weight-bold">Capital: <input class="ml-3" data-bind="value: capital" /></p>
                            <p class="font-weight-bold">Entry: <input class="ml-3" data-bind="value: entry" /></p>
                            <p class="font-weight-bold">Stop Loss: <input class="ml-3" data-bind="value: stopLoss" /></p>
                            <p class="font-weight-bold">Risk %: <input class="ml-3" data-bind="value: risk" /></p>
                            <p class="font-weight-bold">Position Size: <span class="font-weight-normal" data-bind="text: usdposition" /></p>
                        </div>
                    </div>
                       
        
<%--                        <div>
                            <p>Capital: <span data-bind="text: capital" /></p>
                            <p>Entry: <span data-bind="text: entry" /></p>
                            <p>Stop Loss: <span data-bind="text: stopLoss" /></p>
                            <p>Risk %: <span data-bind="text: risk" /></p>
                       </div>--%>
                    


        <div>
        </div>
    <script src="Scripts/knockout-3.4.2.js"></script>
    <script type="text/javascript">
        function vm() {
            this.capital = ko.observable(1);
            this.entry = ko.observable(10000);
            this.stopLoss = ko.observable(9000);
            this.risk = ko.observable(5);

            this.usdposition = ko.computed(function () {
                this.capital(Number(this.capital()));
                this.entry(Number(this.entry()));
                this.stopLoss(Number(this.stopLoss()));
                this.risk(Number(this.risk()));

                var positionsize = (this.capital() * this.risk() / 100) / (1 - (this.stopLoss() / this.entry())) * this.entry();
                return positionsize;
            }, this);
        }

        ko.applyBindings(new vm());
    </script>

</asp:Content>

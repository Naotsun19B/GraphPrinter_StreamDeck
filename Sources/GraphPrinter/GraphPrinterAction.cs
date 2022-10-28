﻿// Copyright 2022 Naotsun. All Rights Reserved.

using StreamDeckLib;
using StreamDeckLib.Messages;
using System.Threading.Tasks;

namespace GraphPrinter
{
    [ActionUuid(Uuid="com.naotsun.graphprinter.clipboard.all")]
    public class GraphPrinterAction : BaseStreamDeckActionWithSettingsModel<Models.WebSocketSettingsModel>
    {
        public override async Task OnKeyUp(StreamDeckEventPayload args)
        {
            await Manager.SetTitleAsync(args.context, args.context);
            await Manager.SetSettingsAsync(args.context, SettingsModel);
        }

        public override async Task OnDidReceiveSettings(StreamDeckEventPayload args)
        {
            await Manager.SetTitleAsync(args.context, "Test");
        }

        public override async Task OnWillAppear(StreamDeckEventPayload args)
        {
            await base.OnWillAppear(args);
            await Manager.SetTitleAsync(args.context, "Test");
        }
    }
}

﻿using Quartz;
using TeslaSolarCharger.Server.Contracts;

namespace TeslaSolarCharger.Server.Scheduling.Jobs;

[DisallowConcurrentExecution]
public class ChargeTimeUpdateJob : IJob
{
    private readonly ILogger<ChargeTimeUpdateJob> _logger;
    private readonly IChargeTimeUpdateService _service;

    public ChargeTimeUpdateJob(ILogger<ChargeTimeUpdateJob> logger, IChargeTimeUpdateService service)
    {
        _logger = logger;
        _service = service;
    }
    public async Task Execute(IJobExecutionContext context)
    {
        _logger.LogTrace("{method}({context})", nameof(Execute), context);
        await Task.Run(() => _service.UpdateChargeTimes()).ConfigureAwait(false);
    }
}

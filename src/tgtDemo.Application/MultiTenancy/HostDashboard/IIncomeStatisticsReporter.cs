using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using tgtDemo.MultiTenancy.HostDashboard.Dto;

namespace tgtDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}
﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeMate.Areas.Identity.Data;
using TimeMate.Models;

namespace TimeMate.Areas.Identity.Data;

public class TimeMateContext : IdentityDbContext<TimeMateUser>
{
    private string connectionString;

    public TimeMateContext(DbContextOptions<TimeMateContext> options)
        : base(options)
    {
    }

    public TimeMateContext(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public DbSet<TimeMateUser> TimeMateUsers { get; set; }
    public DbSet<WorkSpace> Workspaces { get; set; }
    public DbSet<Project> Projects { get; set; }

    public DbSet<ProjectAssignment> ProjectAssignment { get; set; }
    public DbSet<Tasks> Tasks { get; set; }
    public DbSet<WeekSetting> WeekSettings { get; set; }
    public DbSet<TimeSheet> TimeSheets { get; set; }
    public DbSet<ChangeProjectRequests> ChangeProjectRequests { get; set; }
    public DbSet<Message> messages { get; set; }
    public DbSet<LeaveRequest> leaveRequests { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
    }

    public DbSet<TimeMate.Models.Permission> Permission { get; set; }
    public DbSet<TimeMate.Models.Feedback> Feedback { get; set; } = default!;


    public DbSet<TimeMate.Models.GoalSetting> GoalSetting { get; set; } = default!;
}

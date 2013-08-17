import static org.quartz.CronScheduleBuilder.cronSchedule;
import static org.quartz.JobBuilder.newJob;
import static org.quartz.TriggerBuilder.newTrigger;

import java.util.Date;

import org.quartz.CronTrigger;
import org.quartz.JobDetail;
import org.quartz.Scheduler;
import org.quartz.SchedulerFactory;
import org.quartz.SchedulerMetaData;
import org.quartz.impl.StdSchedulerFactory;

public class CronTriggerExample 
{
    public void run() throws Exception 
    {    	
        SchedulerFactory sf = new StdSchedulerFactory();
        Scheduler sched = sf.getScheduler();     
        System.out.println("!!!!!!!!!!!" + sched.getSchedulerInstanceId());
        
        JobDetail job = newJob(SimpleJob.class)
            .withIdentity("JOB_DM_CRANEERROR", "GROUP_DM_CRANEERROR")
            .build();
        
        job.getJobDataMap().put(SimpleJob.COLUMN_TSU, "123456");
        job.getJobDataMap().put(SimpleJob.COLUMN_SKU, "Wurst");
        
        CronTrigger trigger = newTrigger()
            .withIdentity("TRIGGER_DM_CRANEERROR", "GROUP_DM_CRANEERROR")
            .withSchedule(cronSchedule("0 * * * * ?"))
            .build();

        Date ft = sched.scheduleJob(job, trigger);
        System.out.println(job.getKey() + " has been scheduled to run at: " + ft
                + " and repeat based on expression: "
                + trigger.getCronExpression());        
        
        sched.start();
        
        try 
        {
            Thread.sleep(600L * 1000L);
        } 
        catch (Exception e) 
        {
        }
        
        sched.shutdown(true);

        SchedulerMetaData metaData = sched.getMetaData();
        System.out.println("Executed " + metaData.getNumberOfJobsExecuted() + " jobs.");
    }

    public static void main(String[] args) throws Exception 
    {
        CronTriggerExample example = new CronTriggerExample();
        example.run();
    }
}
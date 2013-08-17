import java.util.Date;

import org.quartz.Job;
import org.quartz.JobDataMap;
import org.quartz.JobExecutionContext;
import org.quartz.JobExecutionException;
import org.quartz.JobKey;

public class SimpleJob implements Job {
	
    public static final String COLUMN_TSU = "column tsu";
    public static final String COLUMN_SKU = "column sku";
    
    public SimpleJob() 
    {
    }

    public void execute(JobExecutionContext context) throws JobExecutionException 
    {
        JobKey jobKey = context.getJobDetail().getKey();
        System.out.println(jobKey + " executing at " + new Date());
        
        JobDataMap data = context.getJobDetail().getJobDataMap();
        String tsu = data.getString(COLUMN_TSU);
        String sku = data.getString(COLUMN_SKU);
        System.out.println("TSU: " + tsu + " SKU: " + sku + "\r\n");            
    }
}

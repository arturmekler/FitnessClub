import { FitnessLesson } from "./FitnessLesson"
import { Trainer } from "./Trainer"

export class Schedule {
    public Id : Number
    public LessonId : Number
    public DateTime : Date
    public TrainerId: Number
    public BeginDate: Date
    public EndDate : Date

    public Lesson : FitnessLesson 
    public Trainer : Trainer

}
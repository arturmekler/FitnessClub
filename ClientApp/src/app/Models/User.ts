import { UserFitnessLesson } from "./UserFitnessLesson"

export class User{
    public Id : Number
    public Surname : String
    public Name : String
    public Sex : String
    public Email : String
    public Password : String
    public UserFitnessLesson : UserFitnessLesson[]
}
import { Injectable } from "@angular/core";
import students from "../constants/student.data";

@Injectable({
    providedIn: 'root', // This means the service is provided in the root injector
  })
export class StudentService{

    getAllStudents(){
        return students;
    }

}
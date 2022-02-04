// To parse this data:
//
//   import { Convert, User } from "./file";
//
//   const user = Convert.toUser(json);

export interface UserObject {
    id:           number;
    firstName:    string;
    lastName:     string;
    myCollection: MyCollection[];
    worn30:       MyCollection[];
}

export interface MyCollection {
    id:       number;
    type:     string;
    material: string;
    color:    string;
    images:   string;
    facts:    string;
}

// Converts JSON strings to/from your types
export class UOConvert {
    public static toUserObject(json: string): User {
        return JSON.parse(json);
    }

    public static userObjectToJson(value: User): string {
        return JSON.stringify(value);
    }
}
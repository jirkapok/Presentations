export interface HelloService {
    sayHello(): string;
}

export class SimpleHello implements HelloService {
    constructor() {}

    public sayHello(): string {
        return "Hello world!";
    }
}
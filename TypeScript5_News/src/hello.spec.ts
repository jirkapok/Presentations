import { SimpleHello } from "./hello";

describe("Hello", () => {
    it("should say 'Hello world!'", () => {
        const service = new SimpleHello();
        expect(service.sayHello()).toEqual("Hello world!");
    });
});
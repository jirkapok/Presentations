function loggedMethod(originalMethod: any, _context: any) {

    function replacementMethod(this: any, ...args: any[]) {
        console.log("LOG: Entering method.")
        const result = originalMethod.call(this, ...args);
        console.log("LOG: Exiting method.")
        return result;
    }

    return replacementMethod;
}

function loggedMethodGeneric<This, Args extends any[], Return>(
    target: (this: This, ...args: Args) => Return,
    context: ClassMethodDecoratorContext<This, (this: This, ...args: Args) => Return>
) {
    const methodName = String(context.name);

    function replacementMethod(this: This, ...args: Args): Return {
        console.log(`LOG: Entering method '${methodName}'.`);
        const result = target.call(this, ...args);
        console.log(`LOG: Returning '${result}'.`);
        return result;
    }

    return replacementMethod;
}

export class Persons {
    @loggedMethod
    @loggedMethodGeneric
    public greetTo(name: string): string {
        return `Hello, my name is ${name}.`;
    }
}

new Persons().greetTo("jirka");
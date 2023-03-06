type HasNames = { names: readonly string[] };

// TS4
export function getNamesExactly<T extends HasNames>(arg: T): T["names"] {
    return arg.names;
}

// TS5 see the "const" keyword enforces const like inference by default
export function getNamesExactly5<const T extends HasNames>(arg: T): T["names"] {
    return arg.names;
}

// TS5 see the const and readonly
export function getNamesOnArray5<const T extends readonly string[]>(arg: T): T {
    return arg;
}

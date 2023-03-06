export function exponent(base: number): number;

/**
 * Some method to do arithmetics
 * @overload
 * @param {string} base The base for base implementations
 */
export function exponent(base: string): number;

/**
 * Some method to do arithmetics
 * @param {base | number} base  The base for base implementations
 */
export function exponent(base: string | number): number {
    const toProcess = Number(base);
    return Math.pow(toProcess, 2);
}
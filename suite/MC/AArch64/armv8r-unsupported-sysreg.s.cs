# CS_ARCH_AARCH64, 0, None
0x03,0x20,0x1c,0xd5 = msr	TTBR0_EL2, x3
0x03,0x20,0x3c,0xd5 = mrs	x3, TTBR0_EL2
0x03,0x21,0x1c,0xd5 = msr	VTTBR_EL2, x3
0x03,0x21,0x3c,0xd5 = mrs	x3, VTTBR_EL2
0x03,0x26,0x1c,0xd5 = msr	VSTTBR_EL2, x3
0x03,0x26,0x3c,0xd5 = mrs	x3, VSTTBR_EL2